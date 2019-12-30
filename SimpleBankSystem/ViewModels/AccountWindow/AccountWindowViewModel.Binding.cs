
namespace SimpleBankSystem.ViewModels
{
    public sealed partial class AccountWindowViewModel
    {
        private string accountWindowWindowTitle = "SimpleBankSystem - Account";
        public string AccountWindowWindowTitle
        {
            get
            {
                return this.accountWindowWindowTitle;
            }
            set
            {
                this.accountWindowWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

     

    }
}
