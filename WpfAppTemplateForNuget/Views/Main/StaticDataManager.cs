using System;
using System.Collections.Generic;
using WpfAppTemplateForNuget.Views.Data;

namespace WpfAppTemplateForNuget.Views.Main
{
    public static class StaticDataManager
    {
        public static IEnumerable<DistrictItem> ActualLoadedData { get; internal set; }
        public static DateTime ActualLoadedDataDate { get; internal set; }
    }
}
