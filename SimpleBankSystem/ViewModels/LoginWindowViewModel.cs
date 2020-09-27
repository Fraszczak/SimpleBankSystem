using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;

namespace SimpleBankSystem.ViewModels
{
    class LoginWindowViewModel : ViewModelBase
    {
        #region Commands
            
        #region Fields
            private RelayCommand _showCreateAccountWindowCommand;
            private RelayCommand _loginCommand;
            private RelayCommand _exitCommand;

            #endregion // Fields


        public ICommand ShowCreateAccountWindowCommand
        {
            get
            {
                if (_showCreateAccountWindowCommand == null)
                    _showCreateAccountWindowCommand = new RelayCommand(parm => GoToCreateAccountWindow() , parm => true);
                return _showCreateAccountWindowCommand;
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                    _loginCommand = new RelayCommand(parm => LoginTo(parm), parm =>true);
                return _loginCommand;
            }
        }

        public ICommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                    _exitCommand = new RelayCommand(parm => Exit(), parm => true);
                return _exitCommand;
            }
        }

        #region Methods

        private void GoToCreateAccountWindow()
        {
            CreateAccountWindow createAccountWindow = new CreateAccountWindow();

            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();

            foreach (Window window in Application.Current.Windows.OfType<LoginWindow>())
            {
                ((LoginWindow)window).Close();
            }


            createAccountWindow.Show();
        }

        private void LoginTo(object parameter)
        {
            var values = (object[])parameter;

            var loginBox = values[0] as TextBox;
            var login = loginBox.Text;
            var passwordBox = values[1] as TextBox;
            var password = passwordBox.Text;

            //BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            //blurEffectOwn.LoadingEffect();

            try
            {
                if (new UnitOfWork(new SBSDatabaseContext()).UserRepository.LoginToApp(login, password))
                {
                    var mainWindow = new MainWindow();

                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(LoginWindow))
                            window.Close();

                        if (window.GetType() == typeof(MainWindow))
                        {
                            window.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect login or password.");
            }
        }

        private void Exit()
        {
            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();

            Application.Current.Shutdown();
        }
        #endregion // Methods

        #endregion // Commands

    }
}
