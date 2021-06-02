using System.Windows.Controls;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Menu
{
    public partial class MenuView : UserControl
    {
        private readonly MenuViewModel _viewModel;
        
        public MenuView()
        {
            InitializeComponent();

            this._viewModel = (MenuViewModel) this.DataContext;
            
        }
    }

    internal class MenuViewModel : BaseViewModel
    {
        private ICommand _commandOpenMain;

        public ICommand CommandOpenMain
        {
            get => this._commandOpenMain;
            set
            {
                this._commandOpenMain = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandOpenMain));
            }
        }
    }
}