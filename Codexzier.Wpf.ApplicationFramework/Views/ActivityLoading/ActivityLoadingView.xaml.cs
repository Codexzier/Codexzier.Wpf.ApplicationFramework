using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Views.ActivityLoading
{
    public partial class ActivityLoadingView
    {
        //private readonly ActivityLoadingViewModel _viewModel;
        public ActivityLoadingView()
        {
            this.InitializeComponent();

            //this._viewModel = (ActivityLoadingViewModel)this.DataContext;
            EventBusManager.Register<ActivityLoadingView, BaseMessage>(this.BaseMessageEvent);
        }

        private void BaseMessageEvent(IMessageContainer arg) { }
    }
}
