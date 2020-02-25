namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InvestmentsWindowViewModel
    {
        private string investmentsWindowWindowTitle = "SimpleBankSystem - Investments";
        public string InvestmentsWindowWindowTitle
        {
            get
            {
                return this.investmentsWindowWindowTitle;
            }
            set
            {
                this.investmentsWindowWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

    }
}
