using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity.Infrastructure.Design;
using System.Windows;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Core;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Navigation;
using MaterialDesignThemes.Wpf;
using SimpleBankSystem.Models;
using SimpleBankSystem.Models.Database.Core.Domain;
using SimpleBankSystem.Models.Helpers;

namespace SimpleBankSystem.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
     


        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        #region Title
        public string MainWindowTitle { get; } = unitOfWork.Info.GetData("MainWindowTitle");

        #endregion

        #region Commands

        private RelayCommand _exitCommand;
        private RelayCommand _logoutCommand;
        private RelayCommand _showInvestmentWindowCommand;
        private RelayCommand _showAccoundWindowCommand;
        private RelayCommand _showInfoWindowCommand;
        private RelayCommand _transferFoundsCommand;

        public bool FromSavingAccountIsEnabled { get; set; }
        public bool FromCurrentAccountIsEnabled { get; set; }
        public bool FromCreditAccountIsEnabled { get; set; } 
        public bool ToSavingAccountIsEnabled { get; set; }
        public bool ToCurrentAccountIsEnabled { get; set; }
        public bool ToCreditAccountIsEnabled { get; set; }

        private decimal _operationAmount;
        

        public decimal OperationAmount
        {
            get { return _operationAmount;}
            set { this._operationAmount = value; }
        }

        public ICommand ExitCommand
        {
            get
            {
                if (this._exitCommand == null)
                    this._exitCommand = new RelayCommand(parm => Exit(), parm => true);

                return this._exitCommand;
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
        public ICommand ShowInvestmentWindowCommand
        {
            get
            {
                if (this._showInvestmentWindowCommand == null)
                    this._showInvestmentWindowCommand = new RelayCommand(parm => ShowInvestmentWindow(), parm => true);

                return this._showInvestmentWindowCommand;
            }
        }
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (_showAccoundWindowCommand == null)
                    this._showAccoundWindowCommand = new RelayCommand(parm => ShowAccountWindow(), parm => true);

                return this._showAccoundWindowCommand;
            }
        }
        public ICommand ShowInfoWindowCommand
        {
            get
            {
                if (_showInfoWindowCommand == null)
                    _showInfoWindowCommand = new RelayCommand(parm => ShowInfoWindow(), parm => true);
                return this._showInfoWindowCommand;
            }
        }

        public ICommand TransferFoundsCommand
        {
            get
            {
                if (_transferFoundsCommand == null)
                    this._transferFoundsCommand = new RelayCommand(parem => Transfer(), parm => true);
                return this._transferFoundsCommand;
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

        private void ShowInfoWindow()
        {
            InfoWindow _infoWindow = new InfoWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
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
                if (window.GetType() == typeof(MainWindow))
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
                if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                }
            }

            _accountWindow.Show();
        }

        private void Transfer()
        {
            //MessageBox.Show("FromSavingAccountIsEnabled " + OperationAmount + " " + FromSavingAccountIsEnabled + '\n' +
            //"FromCurrentAccountIsEnabled " + OperationAmount + " " + FromCurrentAccountIsEnabled + '\n' +
            //"FromCreditAccountIsEnabled " + OperationAmount + " " + FromCreditAccountIsEnabled + '\n' +
            //"ToSavingAccountIsEnabled " + OperationAmount + " " + ToSavingAccountIsEnabled + '\n' +
            //"ToCurrentAccountIsEnabled " + OperationAmount + " " + ToCurrentAccountIsEnabled + '\n' +
            //"ToCreditAccountIsEnabled " + OperationAmount + " " + ToCreditAccountIsEnabled + '\n');


        }
        #endregion

        #endregion

      


    }

    
}
