using CodexzierSimpleApplicationFramework.Commands;
using CodexzierSimpleApplicationFramework.Components.Ui.EventBus;
using System;
using System.Windows.Input;
using WpfAppTemplateForNuget.Views.County;

namespace WpfAppTemplateForNuget.Views.Main
{
    internal class ChangedCommandSelectedDistrict : ICommand
    {
        private MainViewModel _viewModel;

        public ChangedCommandSelectedDistrict(MainViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => throw new NotImplementedException();
        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                return;
            }

            if (!EventBusManager.IsViewOpen<CountyView>(1))
            {
                EventBusManager.OpenView<CountyView>(1);

            }

            EventBusManager.Send<CountyView, BaseMessage>(new BaseMessage(parameter), 1);
        }
    }
}