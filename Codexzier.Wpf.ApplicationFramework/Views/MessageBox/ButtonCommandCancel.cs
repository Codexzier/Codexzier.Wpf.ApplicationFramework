using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    internal class ButtonCommandCancel : BaseCommand
    {
        public override void Execute(object parameter)
        {
            EventBusManager.CloseView<MessageBoxView>(10);
        }
    }
}