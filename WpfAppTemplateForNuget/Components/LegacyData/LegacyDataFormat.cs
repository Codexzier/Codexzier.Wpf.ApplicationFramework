using System.Collections.Generic;

namespace WpfAppTemplateForNuget.Components.LegacyData
{
    public class LegacyDataFormat
    {
        public string lastUpdate { get; set; }
        public IList<LegacyDistrictItem> districts { get; set; }
    }
}