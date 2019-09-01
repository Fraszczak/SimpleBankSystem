
namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class AccesibilityWindow
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
