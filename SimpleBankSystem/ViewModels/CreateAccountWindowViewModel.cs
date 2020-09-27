using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Helpers;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels.Commands;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;

namespace SimpleBankSystem.ViewModels
{
    public class CreateAccountWindowViewModel : ViewModelBase
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());
        #region Title
        public string AccountWindowTitle { get; } = unitOfWork.Info.GetData("CreateAccountWindowTitle");

        #endregion // Title
        #region Commands

        #region Fields

        private RelayCommand _exitCommand;
        private RelayCommand _backToCommand;
        private RelayCommand _registryCommand;

        #endregion
        public ICommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                    _exitCommand = new RelayCommand(parm => Exit(), parm => true);
                return _exitCommand;
            }
        }

        public ICommand BackToCommand
        {
            get
            {
                if (_backToCommand == null)
                    _backToCommand = new RelayCommand(parm => BackTo(), parm => true);
                return _backToCommand;
            }
        }

        public ICommand RegistryCommand
        {
            get
            {
                if (_registryCommand == null)
                    _registryCommand = new RelayCommand(Registry, parm => !HasErrors);
                return _registryCommand;
            }
        }

        #region Methods

        private void Exit()
        {
            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();

            Application.Current.Shutdown();
        }

        private void BackTo()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(CreateAccountWindow))
                {
                    BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
                    blurEffectOwn.LoadingEffect();

                    Window newWindow = new LoginWindow();
                    newWindow.Show();
                    window.Close();
                    break;
                }
            }
        }

        private void Registry(object parm)
        {
            var values = (object[])parm;

            var Forename = values[0] as TextBox;
            var forename = Forename.Text;

            var Lastname = values[1] as TextBox;
            var lastname = Lastname.Text;

            var Title = values[2] as TextBox;
            var title = Title.Text;

            var Phone = values[3] as TextBox;
            var phone = Phone.Text;

            var Email = values[4] as TextBox;
            var email = Email.Text;

            var Login = values[5] as TextBox;
            var login = Login.Text;

            var Password = values[6] as TextBox;
            var password = Password.Text;

            var unitOfWork = new UnitOfWork(new SBSDatabaseContext());

            if (unitOfWork.UserRepository.CreateUser(forename, lastname, title, phone, email, login, password))
            {
                foreach (Window window in System.Windows.Application.Current.Windows)
                {
                    if (window.GetType() == typeof(CreateAccountWindow))
                    {
                        new LoginWindow().Show();
                        window.Close();
                    }
                }
            }
        }

    }
        #endregion // Methods

    #endregion // Commands
}





