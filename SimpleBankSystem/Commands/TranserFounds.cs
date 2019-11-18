using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SimpleBankSystem.Models;
using SimpleBankSystem.Views;

namespace SimpleBankSystem.Commands
{
    class TranserFounds : ICommand
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

            var Combobox1 = values[0] as ComboBox;
            var from = Combobox1.Text;
            var ComboBox2 = values[1] as ComboBox;
            var to = Combobox1.Text;






            MessageBox.Show(from + " " + to);




        }
    }
}
