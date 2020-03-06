using System;
using System.Windows.Controls;
using System.Windows.Input;
using SimpleBankSystem.Persistance;

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

            var a = new UnitOfWork(new SBSDatabaseContext());
            a.LoginTo.CreateUser(login, password);

            new BackToCommand().Execute(parameter);
         
           


        }
    }
}
