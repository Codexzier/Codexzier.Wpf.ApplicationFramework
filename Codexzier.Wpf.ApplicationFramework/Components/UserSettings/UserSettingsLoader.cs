using System;
using System.IO;

namespace Codexzier.Wpf.ApplicationFramework.Components.UserSettings
{
    public class UserSettingsLoader<TSettingsFile> : IUserSettingsComponent<TSettingsFile> where TSettingsFile : ISettingsFile
    {
        private static UserSettingsLoader<TSettingsFile> _userSettings;
        private readonly string _settingFile = $"{Environment.CurrentDirectory}\\settings.json";

        public UserSettingsLoader(
            Func<TSettingsFile, string> serialize,
            Func<string, ISettingsFile> deserialize)
        {
            this._serialize = serialize;
            this._deserialize = deserialize;
        }

        public static UserSettingsLoader<TSettingsFile> GetInstance(
            Func<TSettingsFile, string> serialize,
            Func<string, ISettingsFile> deserialize) 
            => _userSettings ??= new UserSettingsLoader<TSettingsFile>(serialize, deserialize);

        private Func<TSettingsFile, string> _serialize;
        private Func<string, ISettingsFile> _deserialize;

        public TSettingsFile Load()
        {
            if (!File.Exists(this._settingFile))
            {
                var settingFile = Activator.CreateInstance<TSettingsFile>();
                settingFile.SetChanged();
                this.Save(settingFile);
            }

            var fileContent = File.ReadAllText(this._settingFile);

            var setting = this._deserialize.Invoke(fileContent);
            //JsonConvert.DeserializeObject<TSettingFile>(fileContent);
            setting.NoChanged();
            return (TSettingsFile)setting;
        }

        public void Save(TSettingsFile firstSetting)
        {
            if (!firstSetting.HasChanged())
            {
                return;
            }

            var toSave = this._serialize.Invoke(firstSetting);
            //JsonConvert.SerializeObject(firstSetting);
            File.WriteAllText(this._settingFile, toSave);
        }
    }
}
