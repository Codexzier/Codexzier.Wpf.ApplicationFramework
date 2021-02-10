using CodexzierSimpleApplicationFramework.Commands;
using CodexzierSimpleApplicationFramework.Components.Ui.EventBus;
using System;
using System.Windows.Input;
using WpfAppTemplateForNuget.Views.Dialog;

namespace WpfAppTemplateForNuget.Views.Setup
{
    internal class ButtonCommandImportDataFromLegacyApplication : ICommand
    {
        private readonly SetupViewModel _viewModel;

        public ButtonCommandImportDataFromLegacyApplication(SetupViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (EventBusManager.IsViewOpen<DialogView>(10))
            {
                return;
            }

            EventBusManager.OpenView<DialogView>(10);

            var ddc = new DataDialogContent
            {
                Header = "Folder Browser"
            };
            EventBusManager.Send<DialogView, BaseMessage>(new BaseMessage(ddc), 10);
        }
    }
}