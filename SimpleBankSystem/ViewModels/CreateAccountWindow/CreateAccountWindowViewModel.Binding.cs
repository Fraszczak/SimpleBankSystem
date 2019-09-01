
namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class CreateAccountWindowViewModel
    {
        private string createAccountWindowWindowTitle = "SimpleBankSystem - Create Account";
        public string CreateAccountWindowWindowTitle
        {
            get
            {
                return this.createAccountWindowWindowTitle;
            }
            set
            {
                this.createAccountWindowWindowTitle = value;
                this.OnPropertyChanged();
            }
        }
    }
}
