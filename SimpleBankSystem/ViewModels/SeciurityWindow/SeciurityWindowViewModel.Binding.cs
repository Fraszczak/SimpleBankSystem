using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class SeciurityWindow
    {
        private string seciurityWindowTitle = "SimpleBankSystem - Seciurity Info";
        public string SeciurityWindowTitle
        {
            get
            {
                return this.seciurityWindowTitle;
            }
            set
            {
                this.seciurityWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

    }
}
