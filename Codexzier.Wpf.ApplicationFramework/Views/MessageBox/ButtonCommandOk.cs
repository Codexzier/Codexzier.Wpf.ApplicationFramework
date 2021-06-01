using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    internal class ButtonCommandOk : BaseCommand
    {
        public override void Execute(object parameter)
        {
            EventBusManager.CloseView<MessageBoxView>(10);
        }
    }
}