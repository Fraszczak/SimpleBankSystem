using SimpleBankSystem.Persistance;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InvestmentsWindowViewModel
    {
        private readonly static UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());
        private string _investmentWindowTitle = unitOfWork.Info.GetData("InvestmentWindowTitle");
        public string InvestmentsWindowitle
        {
            get => _investmentWindowTitle;
            set => OnPropertyChanged();
        } 
        
    }
}
