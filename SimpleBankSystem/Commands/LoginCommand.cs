using SimpleBankSystem.Models;
using SimpleBankSystem.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{
    public class LoginCommand : ICommand
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
            var values = (object[])parameter;

            var loginBox = values[0] as TextBox;
            var login = loginBox.Text;
            var passwordBox = values[1] as PasswordBox;
            var password = passwordBox.Password;

            // weryfikacja uzytkownika po wpisanym loginie

            //DataBase dataBase = new DataBase();

            //dataBase.LoginToApp(ref login, ref password);

            //bool desactiveLoginWindow = false;

            //foreach (Window window in Application.Current.Windows.OfType<MainWindow>())
            //{
            //    desactiveLoginWindow = window.IsActive;
            //}

            //if (desactiveLoginWindow)
            //{
            //    foreach (Window window in Application.Current.Windows.OfType<LoginWindow>())
            //    {
            //        ((LoginWindow)window).Close();
            //    }
            //}
        }
    }
}
