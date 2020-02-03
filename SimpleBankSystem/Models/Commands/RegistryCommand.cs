using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;
using SimpleBankSystem.Views;
using SimpleBankSystem.Views.Effects;

namespace SimpleBankSystem.Commands
{
    class RegistryCommand : ICommand
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
            
            var values = (object[])parameter;

            var Forename = values[0] as TextBox;
            var forename = Forename.Text;
            var Lastname = values[1] as TextBox;
            var lastname = Lastname.Text;

            var Phone = values[2] as TextBox;
            var phone = Phone.Text;
            var City = values[3] as TextBox;
            var city = City.Text;

            var Login = values[4] as TextBox;
            var login = Login.Text;
            var Password = values[5] as TextBox;
            var password = Password.Text;

            var a = new UnitOfWork(new PlutoContext());
            a.LoginTo.CreateUser(login, password);

            new BackToCommand().Execute(parameter);
         
           


        }
    }
}
