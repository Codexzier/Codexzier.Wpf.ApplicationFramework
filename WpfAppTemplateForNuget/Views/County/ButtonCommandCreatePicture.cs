using System;
using System.Windows;
using Codexzier.Wpf.ApplicationFramework.Components.WpfRender;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Views.RenderPicture;

namespace WpfAppTemplateForNuget.Views.County
{
    public class ButtonCommandCreatePicture : BaseCommand
    {
        private readonly RenderPicturePrint _renderPicturePrint;
        private readonly CountyViewModel _viewModel;

        public ButtonCommandCreatePicture(CountyViewModel viewModel, RenderPicturePrint renderPicturePrint)
        {
            this._viewModel = viewModel;
            this._renderPicturePrint = renderPicturePrint;
        }

        public override void Execute(object parameter)
        {
            var filename =
                $"{Environment.CurrentDirectory}/rki-status-{this._viewModel.DistrictData.Date:dd-MM-yyyy}.jpg";

            if (!WpfControlToBitmap.SaveControlImage(this._renderPicturePrint, filename))
                SimpleStatusOverlays.Show("ERROR", "Can't save picture!");

            this._renderPicturePrint.Visibility = Visibility.Hidden;
        }
    }
}