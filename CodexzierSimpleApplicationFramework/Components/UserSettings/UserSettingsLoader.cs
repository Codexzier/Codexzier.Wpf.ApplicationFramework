using Newtonsoft.Json;
using System;
using System.IO;

namespace CodexzierSimpleApplicationFramework.Components.UserSettings
{
    public class UserSettingsLoader : IUserSettingsComponent
    {
        private static UserSettingsLoader _userSettings;
        private readonly string _settingFile = $"{Environment.CurrentDirectory}\\settings.json";

        public static UserSettingsLoader GetInstance() => _userSettings ??= new UserSettingsLoader();
        
        public TSettingFile Load<TSettingFile>() where TSettingFile : ISettingsFile
        {
            if (!File.Exists(this._settingFile))
            {
                var settingFile = Activator.CreateInstance<TSettingFile>();
                settingFile.SetChanged();
                this.Save(settingFile);
            }

            var fileContent = File.ReadAllText(this._settingFile);

            var setting = JsonConvert.DeserializeObject<TSettingFile>(fileContent);
            setting.NoChanged();
            return setting;
        }

        public void Save<TSettingFile>(TSettingFile firstSetting) where TSettingFile : ISettingsFile
        {
            if (!firstSetting.HasChanged)
            {
                return;
            }

            var toSave = JsonConvert.SerializeObject(firstSetting);
            File.WriteAllText(this._settingFile, toSave);
        }
    }
}
