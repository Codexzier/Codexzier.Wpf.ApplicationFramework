using System.Collections.Generic;
using CodexzierSimpleApplicationFramework.Controls.Diagram;
using CodexzierSimpleApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Views.Data;

namespace WpfAppTemplateForNuget.Views.RenderPicture
{
    internal class RenderPicturePrintViewModel : BaseViewModel
    {
        private DistrictItem _districtData;

        public DistrictItem DistrictData
        {
            get => this._districtData;
            set
            {
                this._districtData = value;
                this.OnNotifyPropertyChanged(nameof(this.DistrictData));
            }
        }

        private List<DiagramLevelItem> _countyResults;

        public List<DiagramLevelItem> CountyResults
        {
            get => this._countyResults;
            set
            {
                this._countyResults = value;
                this.OnNotifyPropertyChanged(nameof(this.CountyResults));
            }
        }
    }
}