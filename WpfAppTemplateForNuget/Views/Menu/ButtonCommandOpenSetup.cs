using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using WpfAppTemplateForNuget.Views.Base;
using WpfAppTemplateForNuget.Views.County;
using WpfAppTemplateForNuget.Views.Setup;

namespace WpfAppTemplateForNuget.Views.Menu
{
    internal class ButtonCommandOpenSetup : BaseCommand
    {
        public override void Execute(object parameter)
        {
            base.Execute(parameter);

            if (EventBusManager.IsViewOpen<SetupView>(0)) return;

            if (EventBusManager.IsViewOpen<CountyView>(1)) EventBusManager.CloseView<CountyView>(1);

            EventBusManager.OpenView<SetupView>(0);
        }
    }
}