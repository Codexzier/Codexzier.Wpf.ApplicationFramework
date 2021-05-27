using System.ComponentModel;

namespace Codexzier.Wpf.ApplicationFramework.Views.Base
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
