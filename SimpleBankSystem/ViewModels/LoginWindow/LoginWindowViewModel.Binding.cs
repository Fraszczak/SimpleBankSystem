using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBankSystem.Models;

namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class LoginWindowViewModel
    {
        private string loginWindowTitle = "SimpleBankSystem - Login";
        public string LoginWindowTitle
        {
            get
            {
                return this.loginWindowTitle;
            }
            set
            {
                this.loginWindowTitle = value;
                this.OnPropertyChanged();
            }
        }
       

    }
}