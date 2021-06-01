using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace WpfAppTemplateForNuget.Views.Menu
{
    public partial class MenuView
    {
        private readonly MenuViewModel _viewModel;

        public MenuView()
        {
            this.InitializeComponent();

            this._viewModel = (MenuViewModel) this.DataContext;

            this._viewModel.CommandOpenMain = new ButtonCommandOpenMain();
            this._viewModel.CommandOpenSetup = new ButtonCommandOpenSetup();

            EventBusManager.Register<MenuView, BaseMessage>(this.BaseMessageEvent);
        }

        private void BaseMessageEvent(IMessageContainer arg)
        {
            // do things with the content
        }
    }
}