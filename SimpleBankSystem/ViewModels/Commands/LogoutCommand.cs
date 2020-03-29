using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{
    public class LogoutCommand : ICommand
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
            BlurEffectOwn blurEffectOwn = new BlurEffectOwn(Application.Current.MainWindow);
            blurEffectOwn.LoadingEffect();
            LoginWindow loginWindow = new LoginWindow();

            foreach (Window window in Application.Current.Windows)
            {

                if (window.GetType() == typeof(InfoWindow))
                {
                    window.Close();
                }
                else if (window.GetType() == typeof(InvestmentWindow))
                {
                    window.Close();
                }
                else if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                }
                else if (window.GetType() == typeof(CreateAccountWindow))
                {
                    window.Close();
                }
                else if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                }
            }
            loginWindow.Show();
        }
    }
}
