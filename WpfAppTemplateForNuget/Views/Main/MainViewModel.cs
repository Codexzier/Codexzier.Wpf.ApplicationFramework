using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Views.Data;

namespace WpfAppTemplateForNuget.Views.Main
{
    public class MainViewModel : BaseViewModel
    {
        private DateTime _actualDataFromDate;
        private ICommand _commandSelectedDistrict;
        private ICommand _commandSortByDeaths;
        private ICommand _commandSortByWeekIncidence;
        private int _countyCount;

        private ObservableCollection<DistrictItem> _districts;
        private string _searchCounty;
        private DistrictItem _selected;

        public MainViewModel()
        {
            var list = new List<DistrictItem>
            {
                new DistrictItem {Name = "Keine Daten...", Deaths = 0, WeekIncidence = 0}
            };

            this.Districts = new ObservableCollection<DistrictItem>(list);
        }

        public ObservableCollection<DistrictItem> Districts
        {
            get => this._districts;
            set
            {
                this._districts = value;
                this.OnNotifyPropertyChanged(nameof(this.Districts));
            }
        }

        public DistrictItem Selected
        {
            get => this._selected;
            set
            {
                if (this._selected == null || !this._selected.Equals(value))
                    this.CommandSelectedDistrict?.Execute(value);
                this._selected = value;
                this.OnNotifyPropertyChanged(nameof(this.Selected));
            }
        }

        public string SearchCounty
        {
            get => this._searchCounty;
            set
            {
                this._searchCounty = value;
                this.OnNotifyPropertyChanged(nameof(this.SearchCounty));
            }
        }

        public ICommand CommandSelectedDistrict
        {
            get => this._commandSelectedDistrict;
            set
            {
                this._commandSelectedDistrict = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandSelectedDistrict));
            }
        }

        public DateTime ActualDataFromDate
        {
            get => this._actualDataFromDate;
            set
            {
                this._actualDataFromDate = value;
                this.OnNotifyPropertyChanged(nameof(this.ActualDataFromDate));
            }
        }

        public int CountyCount
        {
            get => this._countyCount;
            set
            {
                this._countyCount = value;
                this.OnNotifyPropertyChanged(nameof(this.CountyCount));
            }
        }

        public ICommand CommandSortByWeekIncidence
        {
            get => this._commandSortByWeekIncidence;
            set
            {
                this._commandSortByWeekIncidence = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandSortByWeekIncidence));
            }
        }

        public ICommand CommandSortByDeaths
        {
            get => this._commandSortByDeaths;
            set
            {
                this._commandSortByDeaths = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandSortByDeaths));
            }
        }
    }
}