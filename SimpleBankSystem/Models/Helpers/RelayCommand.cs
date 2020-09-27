using System;
using System.Diagnostics;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels.Commands
{
    public class RelayCommand : ICommand
    {
        #region Fields

        private Action<object> _execute;
        private Predicate<object> _canExecute;
        private bool hasErrors;

        #endregion // Fields

        #region Constructors

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }
        #endregion //Constructors

        #region ICommand members
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion // ICommand members
        
    }
}
