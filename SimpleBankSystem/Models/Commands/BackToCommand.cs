using SimpleBankSystem.ViewModels;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem
{
    public class BackToCommand : ICommand
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
            MainWindow mainWindow = new MainWindow();

            foreach (Window window in Application.Current.Windows)
            {

                if (window.GetType() == typeof(InfoWindow))
                {
                    window.Close();
                    mainWindow.Show();
                }
                else if (window.GetType() == typeof(InvestmentWindow))
                {
                    window.Close();
                    mainWindow.Show();
                }
                else if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                    mainWindow.Show();
                }
                else if (window.GetType() == typeof(CreateAccountWindow))
                {
                    window.Close();
                    mainWindow = null;
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                }
                else if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                    mainWindow = null;
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                }
            }

            
        }
    }
}
