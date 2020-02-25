namespace SimpleBankSystem.ViewModels
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