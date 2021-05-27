using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using WpfAppTemplateForNuget.Views.Main;

namespace WpfAppTemplateForNuget.Views.Menu
{
    internal class ButtonCommandOpenMain : ICommand
    {
        private readonly MenuViewModel _viewModel;

        public ButtonCommandOpenMain(MenuViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (EventBusManager.IsViewOpen<MainView>(0))
            {
                return;
            }

            EventBusManager.OpenView<MainView>(0);
            //this._viewModel.ViewOpened = EventBusManager.GetViewOpened(0);
            EventBusManager.Send<MainView, BaseMessage>(new BaseMessage(""), 0);
        }
    }
}