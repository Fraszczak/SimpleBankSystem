﻿using System;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels.Commands
{
    class RelayCommand : ICommand
    {

        private Action<object> _execute;
        private Func<object,bool> _canExecute;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }

      public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null)
            {
                throw new NullReferenceException();
            } 

            _execute = execute;
            if (canExecute =)
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
