using System.ComponentModel;

namespace CodexzierSimpleApplicationFramework.Views.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected void OnNotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
