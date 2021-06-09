using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Main
{
    public partial class MainView 
    {
        private readonly MainViewModel _viewModel;
        public MainView()
        {
            this.InitializeComponent();

            this._viewModel = (MainViewModel) this.DataContext;
            this._viewModel.CommandMessageBox = new ButtonCommandTest();
            this._viewModel.CommandAskMessageBox = new ButtonCommandAskMessageBox();
            
            EventBusManager.Register<MainView, BaseMessage>(this.BaseMessageEvent);
        }

        private void BaseMessageEvent(IMessageContainer obj)
        {
            // do things
        }
    }

    public class ButtonCommandAskMessageBox : BaseCommand
    {
        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            
            SimpleStatusOverlays.ShowAsk("Title", "i am asking you. Ok or cancel?", pressOk =>
            {
                // doing things
                if (pressOk)
                {
                }
            });
        }
    }

    public class ButtonCommandTest : BaseCommand
    {
        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            
            SimpleStatusOverlays.Show("tip", "my message");
        }
    }
}