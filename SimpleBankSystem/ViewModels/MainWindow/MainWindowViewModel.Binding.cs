using SimpleBankSystem.Models.Helpers;
using SimpleBankSystem.Persistance;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());
        private string _mainWindowTitle = unitOfWork.Info.GetData("MainWindowTitle");

        //private decimal _currentAccountBalance = unitOfWork.CurrentAccount.GetBallance();
        //private decimal _saveAccountBallance = unitOfWork.SaveAccount.GetBallance();
        //private decimal _creditCardAccountBallance = unitOfWork.CreditCard.GetBallance();
        //private static ObservableCollection<dynamic> _currentAccountTable = IEnumerableToObservableCollectionClass
        //                                                        .IEnumerableToObservableCollection(unitOfWork.CurrentAccount.GetCurrentAccoutTable());
        //private ObservableCollection<dynamic> _saveAccountTable = IEnumerableToObservableCollectionClass
        //                                                         .IEnumerableToObservableCollection(unitOfWork.SaveAccount.GetSaveAccountTable());
        //private ObservableCollection<dynamic> _creditAccountTable = IEnumerableToObservableCollectionClass
        //                                                         .IEnumerableToObservableCollection(unitOfWork.CreditCard.GetSaveAccountTable());

        public string MainWindowTitle
        {
            get => _mainWindowTitle;
            private set => OnPropertyChanged();
        }
        //public decimal CurrentAccountBallance
        //{
        //    get => _currentAccountBalance;
        //    private set => OnPropertyChanged();
        //}
        //public decimal SaveAccountBalance
        //{
        //    get => _saveAccountBallance;
        //    private set => OnPropertyChanged();
        //}
        //public decimal CreditCardAccountBallance
        //{
        //    get => _creditCardAccountBallance;
        //    private set => OnPropertyChanged();
        //}
        //public ObservableCollection<dynamic> CurrentAccountTable
        //{
        //    get => _currentAccountTable;
        //    private set => OnPropertyChanged();
        //}
        //public ObservableCollection<dynamic> SaveAccountTable
        //{
        //    get => _saveAccountTable;
        //    private set => OnPropertyChanged();
        //}
        //public ObservableCollection<dynamic> CreditAccountTable
        //{
        //    get => _creditAccountTable;
        //    private set => OnPropertyChanged();
        //}

    }
}
