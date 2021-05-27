using Codexzier.Wpf.ApplicationFramework.Components.UserSettings;
using WpfAppTemplateForNuget.Components;
using WpfAppTemplateForNuget.Components.UserSettings;

namespace WpfAppTemplateForNuget.Views.Setup
{
    /// <summary>
    /// Interaction logic for SetupView.xaml
    /// </summary>
    public partial class SetupView
    {
        private readonly SetupViewModel _viewModel;
        public SetupView()
        {
            this.InitializeComponent();

            this._viewModel = (SetupViewModel)this.DataContext;

            this._viewModel.CommandLoadRkiDataByApplicationStart = new CheckBoxCommandLoadRkiDataByApplicationStart(this._viewModel);
            this._viewModel.CommandImportDataFromLegacyApplication = new ButtonCommandImportDataFromLegacyApplication(this._viewModel);
            this._viewModel.CommandLoadRkiData = new ButtonCommandLoadRkiData(this._viewModel);
        }

        public override void OnApplyTemplate()
        {
            var setting = UserSettingsLoader<CustomSettingsFile>.GetInstance(SerializeHelper.Serialize, SerializeHelper.Deserialize).Load();
            this._viewModel.LoadRkiDataByApplicationStart = setting.LoadRkiDataByApplicationStart;
        }

    }
}
