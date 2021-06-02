using System.Windows.Controls;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Main
{
    public partial class MainView : UserControl
    {
        private readonly MainViewModel _viewModel;
        public MainView()
        {
            InitializeComponent();

            this._viewModel = (MainViewModel) this.DataContext;
        }
    }

    internal class MainViewModel
    {
    }
}