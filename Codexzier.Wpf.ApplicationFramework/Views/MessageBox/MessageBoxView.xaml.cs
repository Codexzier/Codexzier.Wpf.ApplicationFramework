using System.Windows.Controls;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.MessageBox
{
    /// <summary>
    /// Interaction logic for MessageBoxView.xaml
    /// </summary>
    public partial class MessageBoxView
    {
        private readonly MessageBoxViewModel _viewModel;
        public MessageBoxView()
        {
            this.InitializeComponent();

            this._viewModel = (MessageBoxViewModel)this.DataContext;

            EventBusManager.Register<MessageBoxView, MessageBoxMessage>(this.BaseMessageEvent);
            EventBusManager.Register<MessageBoxView, AskBoxMessage>(this.ASkMessageEvent);
        }

        private void ASkMessageEvent(IMessageContainer arg)
        {
            this.BaseMessageEvent(arg);

            if (arg is AskBoxMessage askBoxMessage)
            {
                this._viewModel.LabelAccept = "Accept";
                this._viewModel.CommandAccept = new ButtonCommandAccept(askBoxMessage);
                this._viewModel.CommandCancel = new ButtonCommandCancel();
            }

        }

        private void BaseMessageEvent(IMessageContainer arg)
        {
            if (arg is MessageBoxMessage boxMessage)
            {
                this._viewModel.CommandAccept = new ButtonCommandOk();
                this._viewModel.LabelAccept = "OK";
                this._viewModel.Title = boxMessage.Title;
                this._viewModel.Message = $"{boxMessage.Content}";
            }
        }
    }
}
