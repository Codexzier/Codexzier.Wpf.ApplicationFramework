using System;
using Codexzier.Wpf.ApplicationTemplate.Components.UserSettings;
using Newtonsoft.Json;

namespace Codexzier.Wpf.ApplicationTemplate.Components
{
    public static class SerializeHelper
    {
        public static Func<CustomSettingsFile, string> Serialize = JsonConvert.SerializeObject;
        public static Func<string, CustomSettingsFile> Deserialize = JsonConvert.DeserializeObject<CustomSettingsFile>;
    }
}