using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem
{

    //Is it goot solution? RelayCommand?  


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
            Window newWindow;

            foreach (Window window in Application.Current.Windows)
            {

                if (   window.GetType() == typeof(InfoWindow) 
                        || window.GetType() == typeof(InvestmentWindow)
                            || window.GetType() == typeof(AccountWindow)
                    )
                {
                    newWindow = SwapWindow(window, new MainWindow());
                    newWindow.Show();
                    break;
                }
                else if (  window.GetType() == typeof(CreateAccountWindow)
                            || window.GetType() == typeof(MainWindow))
                {
                    newWindow = SwapWindow(window, new LoginWindow());
                    newWindow.Show();
                    break;
                }
            }
        }

        private Window SwapWindow(Window oldWindow, Window newWindow)
        {
            oldWindow = null;
            Window _newWindow = newWindow;

            return _newWindow;

        }
    }
}
