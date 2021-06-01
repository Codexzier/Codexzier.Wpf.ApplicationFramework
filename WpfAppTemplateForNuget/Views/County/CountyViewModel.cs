using System.Collections.Generic;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Controls.Diagram;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Views.Data;

namespace WpfAppTemplateForNuget.Views.County
{
    public class CountyViewModel : BaseViewModel
    {
        private ICommand _commandCreatePicture;
        private List<DiagramLevelItem> _countyDeathResults;

        private List<DiagramLevelItem> _countyResults;
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

        public List<DiagramLevelItem> CountyResults
        {
            get => this._countyResults;
            set
            {
                this._countyResults = value;
                this.OnNotifyPropertyChanged(nameof(this.CountyResults));
            }
        }

        public List<DiagramLevelItem> CountyDeathResults
        {
            get => this._countyDeathResults;
            set
            {
                this._countyDeathResults = value;
                this.OnNotifyPropertyChanged(nameof(this.CountyDeathResults));
            }
        }

        public ICommand CommandCreatePicture
        {
            get => this._commandCreatePicture;
            set
            {
                this._commandCreatePicture = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandCreatePicture));
            }
        }
    }
}