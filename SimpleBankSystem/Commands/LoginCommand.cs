using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.Views;
using System;
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

            try
            {
                if (new UnitOfWork(new PlutoContext()).LoginTo.LoginToApp(login, password))
                { 

                    var mainWindow = new MainWindow();

                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(LoginWindow))
                            window.Close();

                        if (window.GetType() == typeof(MainWindow))
                            window.Show();

                    }

                }
            }
            catch(Exception ex)
            {
                //bardzo ogolny zapis, sprecyzuj
                MessageBox.Show(ex.Message);
            }
            
           

        }
    }
}
