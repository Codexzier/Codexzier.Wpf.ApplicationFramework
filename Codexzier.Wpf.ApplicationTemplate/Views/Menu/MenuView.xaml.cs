using System.Windows.Controls;

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
}