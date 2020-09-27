using System.Windows.Input;
using SimpleBankSystem.Persistance;

using System.Windows;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;

namespace SimpleBankSystem.ViewModels
{
    class InvestmentsWindowViewModel : ViewModelBase
    {
        private readonly static UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());
        #region Title
        public string InvestmentsWindowTitle { get; } = unitOfWork.Info.GetData("InvestmentWindowTitle");
        #endregion

        #region Commands
        private RelayCommand _exitCommand;
        private RelayCommand _backToCommand;
        private RelayCommand _logoutCommand;
        private RelayCommand _showAccoundWindowCommand;

        public ICommand ExitCommand
        {
            get
            {
                if (this._exitCommand == null)
                    this._exitCommand = new RelayCommand(parm => Exit(), parm => true);

                return this._exitCommand;
            }
        }
        public ICommand BackToCommand
        {
            get
            {
                if (this._backToCommand == null)
                    this._backToCommand = new RelayCommand(parm => BackTo(), parm => true);

                return this._backToCommand;
            }
        }
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (this._showAccoundWindowCommand == null)
                    this._showAccoundWindowCommand = new RelayCommand(parm => ShowAccountWindow(), parm => true);

                return this._showAccoundWindowCommand;
            }
        }
        public ICommand LogoutCommand
        {
          get
            {
                if (this._logoutCommand == null)
                    this._logoutCommand = new RelayCommand(parm => Logout(), parm => true);

                return this._logoutCommand;
            }
        }

        #region Methods
        private void Exit()
        {
            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();

            Application.Current.Shutdown();
        }

        private void Logout()
        {
            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();
            LoginWindow loginWindow = new LoginWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InvestmentWindow))
                {
                    window.Close();
                }
            }
            loginWindow.Show();
        }

        private void ShowAccountWindow()
        {
            AccountWindow _accountWindow = new AccountWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InvestmentWindow))
                {
                    window.Close();
                }
            }
            _accountWindow.Show();
        }

        private void BackTo()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InvestmentWindow))
                {
                    BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
                    blurEffectOwn.LoadingEffect();

                    Window newWindow = new MainWindow();
                    newWindow.Show();
                    window.Close();
                    break;
                }
            }
        }
        #endregion //Methods
        #endregion // Commands

    }
}
