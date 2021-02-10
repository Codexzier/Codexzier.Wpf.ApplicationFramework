using CodexzierSimpleApplicationFramework.Views.Base;

namespace CodexzierSimpleApplicationFramework.Views.ActivityLoading
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