
using SimpleBankSystem.Models;
using System;


namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private string mainWindowTitle = "SimpleBankSystem";
        public string MainWindowTitle
        {
            get
            {
                return this.mainWindowTitle;
            }
            set
            {
                this.mainWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

        

        

    }
}