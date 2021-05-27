using System;
using System.IO;

namespace Codexzier.Wpf.ApplicationFramework.Components.UserSettings
{
    public class UserSettingsLoader<TSettingsFile> : IUserSettingsComponent<TSettingsFile> where TSettingsFile : ISettingsFile
    {
        private static UserSettingsLoader<TSettingsFile> _userSettings;
        private readonly string _settingFile;
        private Func<TSettingsFile, string> _serialize;
        private Func<string, ISettingsFile> _deserialize;

        public UserSettingsLoader(
            Func<TSettingsFile, string> serialize,
            Func<string, ISettingsFile> deserialize, 
            string filename)
        {
            this._serialize = serialize;
            this._deserialize = deserialize;
            this._settingFile = $"{Environment.CurrentDirectory}\\{filename}";
        }

        public static UserSettingsLoader<TSettingsFile> GetInstance(
            Func<TSettingsFile, string> serialize,
            Func<string, ISettingsFile> deserialize,
            string filename = "defaultSettings") 
            => _userSettings ??= new UserSettingsLoader<TSettingsFile>(serialize, deserialize, filename);

       

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
            File.WriteAllText(this._settingFile, toSave);
        }
    }
}
