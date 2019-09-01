using SimpleBankSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{
    public class LogoutFromMainWindowCommand : ICommand
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
            LoginWindow mainWindow = new LoginWindow();
            mainWindow.Show();

            foreach (Window window in Application.Current.Windows.OfType<MainWindow>())
            {
                ((MainWindow)window).Close();
            }
        }
    }
}