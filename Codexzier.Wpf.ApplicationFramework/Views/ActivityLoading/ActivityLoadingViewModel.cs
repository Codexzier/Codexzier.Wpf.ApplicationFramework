using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationFramework.Views.ActivityLoading
{
    internal class ActivityLoadingViewModel : BaseViewModel
    {
        private int _status;

        public int Status
        {
            get => this._status; set
            {
                this._status = value;
                this.OnNotifyPropertyChanged(nameof(this.Status));
            }
        }
    }
}