using SimpleBankSystem.Persistance;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class AccountWindowViewModel
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _accountWindowTitle = unitOfWork.Info.GetData("AccountWindowTitle");

        public string AccountWindowTitle
        {
         get => _accountWindowTitle;
         private set => OnPropertyChanged();  
        }



    }
}
