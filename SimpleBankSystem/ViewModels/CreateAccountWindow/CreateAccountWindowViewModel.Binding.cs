
using SimpleBankSystem.Persistance;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class CreateAccountWindowViewModel
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _createAccountWindowTitle = unitOfWork.Info.GetData("CreateAccountWindowTitle");
        
        public string CreateAccountWindowTitle
        {
            get => _createAccountWindowTitle;
            private set => OnPropertyChanged();
        }
    }
}
