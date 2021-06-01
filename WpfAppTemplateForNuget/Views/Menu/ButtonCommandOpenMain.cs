using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using WpfAppTemplateForNuget.Views.Base;
using WpfAppTemplateForNuget.Views.Main;

namespace WpfAppTemplateForNuget.Views.Menu
{
    internal class ButtonCommandOpenMain : BaseCommand
    {
        public override void Execute(object parameter)
        {
            if (EventBusManager.IsViewOpen<MainView>(0)) return;

            EventBusManager.OpenView<MainView>(0);
            EventBusManager.Send<MainView, BaseMessage>(new BaseMessage(""), 0);
        }
    }
}