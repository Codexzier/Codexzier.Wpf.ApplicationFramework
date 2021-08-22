using System.Collections.ObjectModel;
using Codexzier.Wpf.ApplicationFramework.Controls.GameTree;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.SecondTab
{
    internal class SecondTabViewModel : BaseViewModel
    {
        private ObservableCollection<GameTreeItem> _gameTreeItems;

        public ObservableCollection<GameTreeItem> GameTreeItems
        {
            get => this._gameTreeItems;
            set
            {
                this._gameTreeItems = value;
                this.OnNotifyPropertyChanged(nameof(this.GameTreeItems));
            }
        }
    }
}