﻿using System.Windows;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;

namespace SimpleBankSystem.ViewModels
{
    class AccountWindowViewModel : ViewModelBase
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        #region Title
        public string AccountWindowTitle { get; } = unitOfWork.Info.GetData("AccountWindowTitle");

        #endregion // Title

        #region Commands
        private RelayCommand _exitCommand;
        private RelayCommand _backToCommand;
        private RelayCommand _showInvestmentWindowCommand;
        private RelayCommand _logoutCommand;
        private RelayCommand _showAccoundWindowCommand;

        public ICommand ExitCommand
        {
            get
            {
                if (this._exitCommand == null)
                    this._exitCommand = new RelayCommand(parm =>Exit(), parm => true);

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
                if (this._showInvestmentWindowCommand == null)
                    this._showInvestmentWindowCommand = new RelayCommand(parm => ShowInvestmentWindow(), parm => true);

                return this._showInvestmentWindowCommand;
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
        public ICommand ShowInfoWindowCommand
        {
            get
            {
                if (_showAccoundWindowCommand == null)
                    _showAccoundWindowCommand = new RelayCommand(parm => ShowInfoWindow(), parm => true);

                return _showAccoundWindowCommand;
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
                if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                }
            }
            loginWindow.Show();
        }

        private void ShowInfoWindow()
        {
            InfoWindow _infoWindow = new InfoWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                }
            }
            _infoWindow.Show();
        }

        private void ShowInvestmentWindow()
        {
            InvestmentWindow _investmentWindow = new InvestmentWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                }
            }
            _investmentWindow.Show();
        }
        
        private void BackTo()
        {
            Window newWindow = new MainWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(AccountWindow))
                {
                    BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
                    blurEffectOwn.LoadingEffect();

                    window.Close();
                    break;
                }
                newWindow.Show();
            }
        }

        #endregion // Methods
        #endregion // Command

    }
}
