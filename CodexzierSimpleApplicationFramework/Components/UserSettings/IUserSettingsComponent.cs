
namespace CodexzierSimpleApplicationFramework.Components.UserSettings
{
    public interface IUserSettingsComponent
    {
        TSettingFile Load<TSettingFile>() where TSettingFile : ISettingsFile;
        void Save<TSettingFile>(TSettingFile firstSetting) where TSettingFile : ISettingsFile;
    }
}