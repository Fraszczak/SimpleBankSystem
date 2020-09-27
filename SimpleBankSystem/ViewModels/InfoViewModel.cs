using System.Windows;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;

namespace SimpleBankSystem.ViewModels
{
    class InfoViewModel : ViewModelBase
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        public string InfoWindowTitle { get; } = unitOfWork.Info.GetData("InfoWindowTitle");
        public string Accessibility { get; } = unitOfWork.Info.GetData("Accessibility");
        public string Security { get; } = unitOfWork.Info.GetData("Security");
        public string LegalInfo { get; } = unitOfWork.Info.GetData("Legal Info");

        #region Commands
        private RelayCommand _exitCommand;
        private RelayCommand _backToCommand;
        private RelayCommand _logoutCommand;
        private RelayCommand _showAccoundWindowCommand;
        private RelayCommand _showInvestmentWindowCommand;

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
        public ICommand ShowInvestmentWindowCommand
        {
            get
            {
                if (_showInvestmentWindowCommand == null)
                    _showInvestmentWindowCommand = new RelayCommand(parm => ShowInvestmentWindow(), parm => true);
                return this._showInvestmentWindowCommand;
            }
        }
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (_showAccoundWindowCommand == null)
                    _showAccoundWindowCommand = new RelayCommand(parm => ShowAccountWindow(), parm => true);
                return this._showAccoundWindowCommand;
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                if (_logoutCommand == null)
                    _logoutCommand = new RelayCommand(parm => Logout(), parm => true);

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
                if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                }
            }
            loginWindow.Show();
        }
        private void BackTo()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InfoWindow))
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
        private void ShowInvestmentWindow()
        {
            InvestmentWindow _investmentWindow = new InvestmentWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InfoWindow))
                {
                    window.Close();
                }
            }
            _investmentWindow.Show();
        }
        private void ShowAccountWindow()
        {
            AccountWindow _accountWindow = new AccountWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(InfoWindow))
                {
                    window.Close();
                }
            }
            _accountWindow.Show();

        }
        #endregion // Methods   
        #endregion // Commands

    }
}
