using System.Windows.Controls;

namespace WpfAppTemplateForNuget.Views.RenderPicture
{
    /// <summary>
    ///     Interaction logic for RenderPicturePrint.xaml
    /// </summary>
    public partial class RenderPicturePrint : UserControl
    {
        private readonly RenderPicturePrintViewModel _viewModel;

        public RenderPicturePrint()
        {
            this.InitializeComponent();

            this._viewModel = (RenderPicturePrintViewModel) this.DataContext;
        }
    }
}