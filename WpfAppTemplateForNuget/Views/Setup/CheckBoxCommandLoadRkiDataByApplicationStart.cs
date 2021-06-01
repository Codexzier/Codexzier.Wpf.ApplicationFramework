using Codexzier.Wpf.ApplicationFramework.Components.UserSettings;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Components;
using WpfAppTemplateForNuget.Components.UserSettings;

namespace WpfAppTemplateForNuget.Views.Setup
{
    internal class CheckBoxCommandLoadRkiDataByApplicationStart : BaseCommand
    {
        private readonly SetupViewModel _viewModel;

        public CheckBoxCommandLoadRkiDataByApplicationStart(SetupViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            var userSettings =
                UserSettingsLoader<CustomSettingsFile>.GetInstance(SerializeHelper.Serialize,
                    SerializeHelper.Deserialize);
            var setting = userSettings.Load();

            setting.LoadRkiDataByApplicationStart = this._viewModel.LoadRkiDataByApplicationStart;

            userSettings.Save(setting);
        }
    }
}