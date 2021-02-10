using System;
using System.Collections.Generic;

namespace WpfAppTemplateForNuget.Components.Data
{
    public class Landkreise
    {
        public DateTime Date { get; set; }

        public IList<Landkreis> Districts { get; set; }
    }
}
