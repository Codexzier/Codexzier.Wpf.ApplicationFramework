
namespace Codexzier.Wpf.ApplicationFramework.Components.UserSettings
{
    public interface IUserSettingsComponent<TSettingFile> where TSettingFile : ISettingsFile
    {
        TSettingFile Load();
        void Save(TSettingFile firstSetting);
    }
}