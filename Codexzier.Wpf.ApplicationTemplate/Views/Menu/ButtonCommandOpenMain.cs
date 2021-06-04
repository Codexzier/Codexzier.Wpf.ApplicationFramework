using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;
using Codexzier.Wpf.ApplicationTemplate.Views.Main;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Menu
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