using System.Windows.Controls;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    public partial class MessageBoxView
    {
        private readonly MessageBoxViewModel _viewModel;
        public MessageBoxView()
        {
            this.InitializeComponent();

            this._viewModel = (MessageBoxViewModel)this.DataContext;

            EventBusManager.Register<MessageBoxView, MessageBoxMessage>(this.TryPrepareMessageBox);
            EventBusManager.Register<MessageBoxView, AskBoxMessage>(this.TryPrepareAskBoxMessage);
        }

        private void TryPrepareMessageBox(IMessageContainer arg)
        {
            if (!(arg is MessageBoxMessage boxMessage)) return ;
            
            this._viewModel.CommandAccept = new ButtonCommandOk();
            this._viewModel.LabelAccept = "OK";
            this._viewModel.Title = boxMessage.Title;
            this._viewModel.Message = $"{boxMessage.Content}";
        }

        private void TryPrepareAskBoxMessage(IMessageContainer arg)
        {
            if (!(arg is AskBoxMessage askBoxMessage)) return;
            
            this._viewModel.LabelAccept = "Accept";
            this._viewModel.CommandAccept = new ButtonCommandAccept(askBoxMessage);
            this._viewModel.CommandCancel = new ButtonCommandCancel();
        }
    }
}
