using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Codexzier.Wpf.ApplicationFramework.Commands;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.SecondTab
{
    /// <summary>
    /// Interaction logic for SecondTabView.xaml
    /// </summary>
    public partial class SecondTabView : UserControl
    {
        private readonly SecondTabViewModel _viewModel;
        public SecondTabView()
        {
            InitializeComponent();

            EventBusManager.Register<SecondTabView, BaseMessage>(this.BaseMessageReceiver);
        }

        private async void BaseMessageReceiver(IMessageContainer obj)
        {
            Debug.WriteLine($"ActivityOn, Channel {SimpleStatusOverlays.ActivityChannel}");
            SimpleStatusOverlays.ActivityOn();

            await Task.Delay(2000);

            Debug.WriteLine($"ActivityOff, Channel {SimpleStatusOverlays.ActivityChannel}");
            SimpleStatusOverlays.ActivityOff();
        }
    }

    internal class SecondTabViewModel
    {
    }
}
