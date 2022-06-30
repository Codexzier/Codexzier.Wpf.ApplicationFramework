using System;
using System.Windows;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.ActivityLoading;
using Codexzier.Wpf.ApplicationFramework.Views.MessageBox;

namespace Codexzier.Wpf.ApplicationFramework.Views.Base
{
    public static class SimpleStatusOverlays
    {
        public static int MessageBoxChannel = 101;
        public static int ActivityChannel = 100;

        public static void Show(string title, string message)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.Send<MessageBoxView, MessageBoxMessage>(new MessageBoxMessage(title, message), MessageBoxChannel, true);
            });
        }

        public static void ActivityOn()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.OpenView<ActivityLoadingView>(ActivityChannel);
            });
        }

        public static void ActivityOff()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.CloseView<ActivityLoadingView>(ActivityChannel);
            });
        }

        public static void ShowAsk(string title, string message, Action<bool> doingByPressedOk)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                EventBusManager.Send<MessageBoxView, AskBoxMessage>(new AskBoxMessage(title, message, doingByPressedOk), MessageBoxChannel, true);
            });
        }
    }
}
