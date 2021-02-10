using System;
using System.Windows;
using CodexzierSimpleApplicationFramework.Components.Ui.EventBus;
using CodexzierSimpleApplicationFramework.Views.ActivityLoading;
using CodexzierSimpleApplicationFramework.Views.MessageBox;

namespace CodexzierSimpleApplicationFramework.Views.Base
{
    public static class SimpleStatusOverlays
    {
        public static void Show(string title, string message)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.Send<MessageBoxView, MessageBoxMessage>(new MessageBoxMessage(title, message), 10, true);
            });
        }

        public static void ActivityOn()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.OpenView<ActivityLoadingView>(10);
            });
        }

        public static void ActivityOff()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.CloseView<ActivityLoadingView>(10);
            });
        }

        public static void ShowAsk(string title, string message, Action<bool> safeData)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.Send<MessageBoxView, AskBoxMessage>(new AskBoxMessage(title, message, safeData), 10, true);
            });
        }
    }
}
