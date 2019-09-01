using MVVM_WPF_BankApp.Models;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SimpleBankSystem.Commands
{


    public class ShowCreateAccountWindowCommand : ICommand
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


            CreateAccountWindow createAccountWindow = new CreateAccountWindow();
            createAccountWindow.Show();

            foreach (Window window in Application.Current.Windows.OfType<LoginWindow>())
            {
                ((LoginWindow)window).Close();
            }

        }
    }
}