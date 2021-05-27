using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using WpfAppTemplateForNuget.Views.County;
using WpfAppTemplateForNuget.Views.Setup;

namespace WpfAppTemplateForNuget.Views.Menu
{
    internal class ButtonCommandOpenSetup : ICommand
    {
        private readonly MenuViewModel _viewModel;

        public ButtonCommandOpenSetup(MenuViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            if (EventBusManager.IsViewOpen<SetupView>(0))
            {
                return;
            }

            if (EventBusManager.IsViewOpen<CountyView>(1))
            {
                EventBusManager.CloseView<CountyView>(1);
            }

            EventBusManager.OpenView<SetupView>(0);
            //this._viewModel.ViewOpened = EventBusManager.GetViewOpened(0);
        }
    }
}