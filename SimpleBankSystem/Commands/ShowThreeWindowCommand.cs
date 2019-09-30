using SimpleBankSystem.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{


    public class ShowThreeWindowCommand : ICommand
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
            ThreeContentWindow accountWindow = new ThreeContentWindow();

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
            
            accountWindow.Show();
        }
    }
}
