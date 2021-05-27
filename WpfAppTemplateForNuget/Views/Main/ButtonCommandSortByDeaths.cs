using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Views.Data;

namespace WpfAppTemplateForNuget.Views.Main
{
    internal class ButtonCommandSortByDeaths : ICommand
    {
        private MainViewModel _viewModel;

        public ButtonCommandSortByDeaths(MainViewModel viewModel) => this._viewModel = viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            if (StaticDataManager.ActualLoadedData == null || !StaticDataManager.ActualLoadedData.Any())
            {
                SimpleStatusOverlays.Show("TIP", "No data loaded");
                return;
            }

            var ordered = StaticDataManager.ActualLoadedData.OrderByDescending(order => order.Deaths);
            this._viewModel.Districts = new ObservableCollection<DistrictItem>(ordered);
        }
    }
}