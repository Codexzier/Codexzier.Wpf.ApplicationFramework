using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    internal class ButtonCommandAccept : ICommand
    {
        private readonly AskBoxMessage _askBoxMessage;

        public ButtonCommandAccept(AskBoxMessage askBoxMessage)
        {
            this._askBoxMessage = askBoxMessage;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            this._askBoxMessage.Execute(true);
            EventBusManager.CloseView<MessageBoxView>(10);
        }

        public event EventHandler CanExecuteChanged;
    }
}