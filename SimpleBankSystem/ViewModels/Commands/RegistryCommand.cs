using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.ViewModels;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleBankSystem.Commands
{
    class RegistryCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {
            UnitOfWork unitOfWork;

            var values = (object[])parameter;

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

            
       
            unitOfWork = new UnitOfWork(new SBSDatabaseContext());

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
}
