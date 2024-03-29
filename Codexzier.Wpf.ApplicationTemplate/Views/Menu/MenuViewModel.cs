﻿using System.Windows.Input;
using Codexzier.Wpf.ApplicationFramework.Views.Base;

namespace Codexzier.Wpf.ApplicationTemplate.Views.Menu
{
    internal class MenuViewModel : BaseViewModel
    {
        private ICommand _commandOpenMain;
        private ICommand _commandOpenSecond;

        public ICommand CommandOpenMain
        {
            get => this._commandOpenMain;
            set
            {
                this._commandOpenMain = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandOpenMain));
            }
        }

        public ICommand CommandOpenSecond
        {
            get => this._commandOpenSecond;
            set
            {
                this._commandOpenSecond = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandOpenSecond));
            }
        }
    }
}