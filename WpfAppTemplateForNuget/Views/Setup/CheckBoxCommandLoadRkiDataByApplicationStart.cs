using System;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Components.UserSettings;
using WpfAppTemplateForNuget.Components;
using WpfAppTemplateForNuget.Components.UserSettings;

namespace WpfAppTemplateForNuget.Views.Setup
{
    internal class CheckBoxCommandLoadRkiDataByApplicationStart : ICommand
    {
        private readonly SetupViewModel _viewModel;

        public CheckBoxCommandLoadRkiDataByApplicationStart(SetupViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            var userSettings = UserSettingsLoader<CustomSettingsFile>.GetInstance(SerializeHelper.Serialize, SerializeHelper.Deserialize);
            var setting = userSettings.Load();

            setting.LoadRkiDataByApplicationStart = this._viewModel.LoadRkiDataByApplicationStart;

            userSettings.Save(setting);
        }
    }
}