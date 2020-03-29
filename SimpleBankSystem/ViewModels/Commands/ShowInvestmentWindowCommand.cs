using SimpleBankSystem.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{
    public class ShowInvestmentWindowCommand : ICommand
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
            InvestmentWindow investmentWindow = new InvestmentWindow();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    window.Close();
                }
                else if (window.GetType() == typeof(AccountWindow))
                {
                    window.Close();
                }
            }
            
            investmentWindow.Show();
        }
    }
}