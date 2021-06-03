
namespace Codexzier.Wpf.ApplicationFramework.Components.UserSettings
{
    public interface IUserSettingsComponent<TSettingFile> where TSettingFile : ISettingsFile
    {
        /// <summary>
        /// Load settingFile by activator. Check ctor if parameter missing.
        /// </summary>
        /// <returns>Return the load data of settings.</returns>
        TSettingFile Load();
        void Save(TSettingFile firstSetting);
    }
}