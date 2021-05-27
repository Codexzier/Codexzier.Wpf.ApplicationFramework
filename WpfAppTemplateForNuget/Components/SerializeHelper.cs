using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using WpfAppTemplateForNuget.Components.UserSettings;

namespace WpfAppTemplateForNuget.Components
{
    public static class SerializeHelper
    {
        public static Func<CustomSettingsFile, string> Serialize = new Func<CustomSettingsFile, string>(JsonConvert.SerializeObject);
        public static Func<string, CustomSettingsFile> Deserialize = new Func<string, CustomSettingsFile>(JsonConvert.DeserializeObject<CustomSettingsFile>);
    }
}
