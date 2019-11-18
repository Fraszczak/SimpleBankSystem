using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using SimpleBankSystem.Models;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class ThreeWindowContent
    {
        private string accesibilityWindowTitle = "SimpleBankSystem - Accesibility Info";
        public string AccesibilityWindowTitle
        {
            get
            {
                return this.accesibilityWindowTitle;
            }
            set
            {
                this.accesibilityWindowTitle = value;
                this.OnPropertyChanged();
            }
        }



    }
}
