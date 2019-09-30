using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{


    public class ShowMainWindowCommand : ICommand
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
                
                if (window.GetType() == typeof(ThreeContentWindow))
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
            }
            
            mainWindow.Show();
        }
    }
}
