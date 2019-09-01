using SimpleBankSystem.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{


    public class ShowAccountWindowCommand : ICommand
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

            AccountWindow accountWindow = new AccountWindow();
            accountWindow.Show();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                }
                if (window.GetType() == typeof(InvestmentWindow))
                {
                    window.Close();
                }
            }
        }
    }
}
