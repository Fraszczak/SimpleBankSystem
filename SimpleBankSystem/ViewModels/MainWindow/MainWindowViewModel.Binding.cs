using SimpleBankSystem.Models.Helpers;
using SimpleBankSystem.Persistance;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private static UnitOfWork unitOfWork = new UnitOfWork(new PlutoContext());

        #region title
        private string _mainWindowTitle = "SimpleBankSystem";
        public string MainWindowTitle
        {
            get
            {
                return this._mainWindowTitle;
            }
            set
            {
                this._mainWindowTitle = value;
                this.OnPropertyChanged();
            }
        }
        #endregion

        #region Ballances
        private decimal _currentAccountBalance = unitOfWork.CurrentAccount.GetBallance();
        public decimal CurrentAccountBallance
        {
            get { return _currentAccountBalance; }
            set
            {
                OnPropertyChanged();
                _currentAccountBalance = value;
            }
        }

        private decimal _saveAccountBallance = unitOfWork.SaveAccount.GetBallance();
        public decimal SaveAccountBalance
        {
            get { return _saveAccountBallance; }
            set
            {
                OnPropertyChanged();
                _saveAccountBallance = value;
            }
        }

        private decimal _creditCardAccountBallance = unitOfWork.CreditCard.GetBallance();
        public decimal CreditCardAccountBallance
        {
            get { return _creditCardAccountBallance; }
            set
            {
                OnPropertyChanged();
                _creditCardAccountBallance = value;
            }
        }
        #endregion

        #region CurrentAccount
        private ObservableCollection<dynamic> _currentAccountTable = IEnumerableToObservableCollectionClass
                                                                    .IEnumerableToObservableCollection(unitOfWork.CurrentAccount.GetCurrentAccoutTable());
        public ObservableCollection<dynamic> CurrentAccountTable
        {
            get { return _currentAccountTable; }
            set
            {
                _currentAccountTable = value;
                OnPropertyChanged();
            }
        }


        #endregion
        #region SaveAccount
        private ObservableCollection<dynamic> _saveAccountTable = IEnumerableToObservableCollectionClass
                                                                  .IEnumerableToObservableCollection(unitOfWork.SaveAccount.GetSaveAccountTable());
    public ObservableCollection<dynamic> SaveAccountTable
        {
            get { return _saveAccountTable; }
            set
            {
                _saveAccountTable = value;
                OnPropertyChanged();
            }
        }


        #endregion
        #region Credit Account
        private ObservableCollection<dynamic> _creditAccountTable = IEnumerableToObservableCollectionClass
                                                                  .IEnumerableToObservableCollection(unitOfWork.CreditCard.GetSaveAccountTable());
        public ObservableCollection<dynamic> CreditAccountTable
        {
            get { return _creditAccountTable; }
            set
            {
                _creditAccountTable = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
