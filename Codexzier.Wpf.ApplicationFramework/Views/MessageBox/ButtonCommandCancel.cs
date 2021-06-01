using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    internal class ButtonCommandCancel : ICommand
    {
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            EventBusManager.CloseView<MessageBoxView>(10);
        }

        public event EventHandler CanExecuteChanged;
    }
}