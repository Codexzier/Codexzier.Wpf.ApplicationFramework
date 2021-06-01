using System;
using Newtonsoft.Json;
using WpfAppTemplateForNuget.Components.UserSettings;

namespace WpfAppTemplateForNuget.Components
{
    public static class SerializeHelper
    {
        public static Func<CustomSettingsFile, string> Serialize = JsonConvert.SerializeObject;
        public static Func<string, CustomSettingsFile> Deserialize = JsonConvert.DeserializeObject<CustomSettingsFile>;
    }
}