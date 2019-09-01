
using SimpleBankSystem.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{
    public class LogoutFromInvestmentWindowCommand : ICommand
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
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();

            foreach (Window window in Application.Current.Windows.OfType<InvestmentWindow>())
            {
                ((InvestmentWindow)window).Close();
            }
        }
    }
}
