using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using Codexzier.Wpf.ApplicationTemplate.Views.SecondTab;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Menu
{
    public partial class MenuView
    {
        private readonly MenuViewModel _viewModel;
        
        public MenuView()
        {
            this.InitializeComponent();

            this._viewModel = (MenuViewModel) this.DataContext;
            
            this._viewModel.CommandOpenMain = new ButtonCommandOpenMain();
            this._viewModel.CommandOpenSecond = new ButtonCommandOpenSecond();
        }
    }

    public class ButtonCommandOpenSecond : BaseCommand
    {
        public override void Execute(object parameter)
        {
            if (EventBusManager.IsViewOpen<SecondTabView>(0)) return;

            EventBusManager.OpenView<SecondTabView>(0);
            EventBusManager.Send<SecondTabView, BaseMessage>(new BaseMessage(""), 0);
        }
    }
}