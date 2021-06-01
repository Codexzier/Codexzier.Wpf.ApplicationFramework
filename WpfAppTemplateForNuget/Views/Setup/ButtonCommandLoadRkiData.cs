using Codexzier.Wpf.ApplicationFramework.Views.Base;
using WpfAppTemplateForNuget.Components.RkiCoronaLandkreise;
using WpfAppTemplateForNuget.Views.Base;

namespace WpfAppTemplateForNuget.Views.Setup
{
    internal class ButtonCommandLoadRkiData : BaseCommand
    {
        public override void Execute(object parameter)
        {
            var component = RkiCoronaLandkreiseComponent.GetInstance();
            component.RkiDataErrorEvent += this.Component_RkiDataErrorEvent;
            component.LoadData(out var saveIt);
            saveIt(true);
            component.RkiDataErrorEvent -= this.Component_RkiDataErrorEvent;
        }

        private void Component_RkiDataErrorEvent(string message)
        {
            SimpleStatusOverlays.Show("ERROR", message);
        }
    }
}