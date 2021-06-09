using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Main
{
    internal class MainViewModel : BaseViewModel
    {
        private ICommand _commandMessageBox;
        private ICommand _commandAskMessageBox;

        public ICommand CommandMessageBox
        {
            get => this._commandMessageBox;
            set
            {
                this._commandMessageBox = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandMessageBox));
            }
        }

        public ICommand CommandAskMessageBox
        {
            get => this._commandAskMessageBox;
            set
            {
                this._commandAskMessageBox = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandAskMessageBox));
            }
        }
    }
}