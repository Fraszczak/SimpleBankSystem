
using SimpleBankSystem.Models;
using System;
using System.Data;


namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private string mainWindowTitle = "SimpleBankSystem";
        public string MainWindowTitle
        {
            get
            {
                return this.mainWindowTitle;
            }
            set
            {
                this.mainWindowTitle = value;
                this.OnPropertyChanged();
            }
        }



        #region Total Values


        private decimal _currentAccountTotal = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM CurrentAccountSpendsTable");
        public Decimal CurrentAccountTotal
        {
            get
            {
                return _currentAccountTotal;
            }
            set
            {
                _currentAccountTotal = value;
                OnPropertyChanged("CurrentAccountTotalValue");
            }

        }

        private decimal _savingAccountTotal = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM SavingAccountTable");
        public Decimal SavingAccountTotal
        {
            get
            {
                return _savingAccountTotal;
            }
            set
            {
                _savingAccountTotal = value;
                OnPropertyChanged("SavingAccountTotalValue");
            }

        }

        private decimal _creditCardAccountTotal = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM CreditCardAccountSpendsTable");
        public Decimal CreditCardAccountTotal
        {
            get
            {
                return _creditCardAccountTotal;
            }
            set
            {
                _creditCardAccountTotal = value;
                OnPropertyChanged("CreditCardAccountTotalValue");
            }
             
        }
        #endregion
        #region List of values
        private decimal _currentAccountFirsValue = DataBase.Instance.DecimalExecuteQuery("SELECT SpendPrices FROM CurrentAccountSpendsTable WHERE Id = 1");
        public decimal CurrentAccountFirstValue
        {
            get
            {
                return _currentAccountFirsValue;
            }
            set
            {
                _currentAccountFirsValue = value;
                OnPropertyChanged("CurrentAccountFirstValue");
            }
        }

        private decimal _currentAccountSecondValue = DataBase.Instance.DecimalExecuteQuery("SELECT SpendPrices FROM CurrentAccountSpendsTable WHERE Id = 2");
        public decimal CurrentAccountSecondValue
        {
            get
            {
                return _currentAccountSecondValue;
            }
            set
            {
                _currentAccountSecondValue = value;
                OnPropertyChanged("CurrentAccountFirstValue");
            }

        }

        private decimal _currentAccountThirdValue = DataBase.Instance.DecimalExecuteQuery("SELECT SpendPrices FROM CurrentAccountSpendsTable WHERE Id = 3");
        public decimal CurrentAccountThirdValue
        {
            get
            {
                return _currentAccountThirdValue;
            }
            set
            {
                _currentAccountThirdValue = value;
                OnPropertyChanged("CurrentAccountFirstValue");
            }

        }
        #endregion
        #region List of transaction names
        private string _currentAccountFirsValueName = DataBase.Instance.StringExecuteQuery("SELECT SpendNames FROM CurrentAccountSpendsTable WHERE Id = 1");
        public string CurrentAccountFirstValueName
        {
            get
            {
                return _currentAccountFirsValueName;
            }
            set
            {
                _currentAccountFirsValueName = value;
                OnPropertyChanged("CurrentAccountFirstValueName");
            }
        }

        private string _currentAccountSecondValueName = DataBase.Instance.StringExecuteQuery("SELECT SpendNames FROM CurrentAccountSpendsTable WHERE Id = 2");
        public string CurrentAccountSecondValueName
        {
            get
            {
                return _currentAccountSecondValueName;
            }
            set
            {
                _currentAccountSecondValueName = value;
                OnPropertyChanged("CurrentAccountSecondValueName");
            }
        }

        private string _currentAccountThirdValueName = DataBase.Instance.StringExecuteQuery("SELECT SpendNames FROM CurrentAccountSpendsTable WHERE Id = 3");
        public string CurrentAccountThirdValueName
        {
            get
            {
                return _currentAccountThirdValueName;
            }
            set
            {
                _currentAccountThirdValueName = value;
                OnPropertyChanged("CurrentAccountThirdValueName");
            }
        }

        #endregion
        #region List of transaction dates
        private string _currentAccountFirsDate = DataBase.Instance.StringExecuteQuery("SELECT SpendDates FROM CurrentAccountSpendsTable WHERE Id = 1");
        public string CurrentAccountFirstDate
        {
            get
            {
                return _currentAccountFirsDate;
            }
            set
            {
                _currentAccountFirsDate = value;
                OnPropertyChanged("CurrentAccountFirstDate");
            }
        }
        private string _currentAccountSecondDate = DataBase.Instance.StringExecuteQuery("SELECT SpendDates FROM CurrentAccountSpendsTable WHERE Id = 2");
        public string CurrentAccountSecondtDate
        {
            get
            {
                return _currentAccountSecondDate;
            }
            set
            {
                _currentAccountSecondDate = value;
                OnPropertyChanged("CurrentAccountSecondDate");
            }
        }
        private string _currentAccountThirdDate = DataBase.Instance.StringExecuteQuery("SELECT SpendDates FROM CurrentAccountSpendsTable WHERE Id = 3");
        public string CurrentAccountThirdDate
        {
            get
            {
                return _currentAccountThirdDate;
            }
            set
            {
                _currentAccountThirdDate = value;
                OnPropertyChanged("CurrentAccountThirdDate");
            }
        }
        #endregion

    }
}