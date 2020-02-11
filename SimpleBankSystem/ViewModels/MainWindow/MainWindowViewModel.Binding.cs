using SimpleBankSystem.Persistance;
using SimpleBankSystem.Views;
using System;
using System.Collections;
using System.Windows;

namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private string _mainWindowTitle = "SimpleBankSystem";
        public string MainWindowTitle
        {
            get
            {
                return this._mainWindowTitle;
            }
            set
            {
                this._mainWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

       


       
    }
}
