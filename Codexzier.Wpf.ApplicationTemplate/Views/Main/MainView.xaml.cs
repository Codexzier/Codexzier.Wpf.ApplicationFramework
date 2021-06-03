using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using System;
using System.Windows.Controls;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Main
{
    public partial class MainView : UserControl
    {
        private readonly MainViewModel _viewModel;
        public MainView()
        {
            this.InitializeComponent();

            this._viewModel = (MainViewModel) this.DataContext;
            EventBusManager.Register<MainView, BaseMessage>(this.BaseMessageEvent);
        }

        private void BaseMessageEvent(IMessageContainer obj)
        {
            // do things
        }
    }
}