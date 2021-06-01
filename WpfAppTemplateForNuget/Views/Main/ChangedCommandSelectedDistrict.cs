using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using WpfAppTemplateForNuget.Views.Base;
using WpfAppTemplateForNuget.Views.County;

namespace WpfAppTemplateForNuget.Views.Main
{
    internal class ChangedCommandSelectedDistrict : BaseCommand
    {
        public override void Execute(object parameter)
        {
            if (parameter == null) return;

            if (!EventBusManager.IsViewOpen<CountyView>(1)) EventBusManager.OpenView<CountyView>(1);

            EventBusManager.Send<CountyView, BaseMessage>(new BaseMessage(parameter), 1);
        }
    }
}