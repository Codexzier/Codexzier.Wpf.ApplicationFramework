using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    internal class ButtonCommandAccept : BaseCommand
    {
        private readonly AskBoxMessage _askBoxMessage;

        public ButtonCommandAccept(AskBoxMessage askBoxMessage)
        {
            this._askBoxMessage = askBoxMessage;
        }

        public override void Execute(object parameter)
        {
            this._askBoxMessage.Execute(true);
            EventBusManager.CloseView<MessageBoxView>(101);
        }
    }
}