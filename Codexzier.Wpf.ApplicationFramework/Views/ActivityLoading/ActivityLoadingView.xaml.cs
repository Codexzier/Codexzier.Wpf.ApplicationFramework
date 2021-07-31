using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.ActivityLoading
{
    public partial class ActivityLoadingView
    {
        public ActivityLoadingView()
        {
            this.InitializeComponent();
            EventBusManager.Register<ActivityLoadingView, BaseMessage>(this.BaseMessageEvent);
        }

        private void BaseMessageEvent(IMessageContainer arg) { }
    }
}
