
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class LegalInfoWindow
    {
        private ICommand exitCommand;
        private ICommand backCommand;



        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
            }
            private set
            {
                this.exitCommand = value;
            }
        }
        public ICommand BackCommand
        {
            get
            {
                if (this.backCommand == null)
                    this.backCommand = new BackToCommand();

                return this.backCommand;
            }
            private set
            {
                BackCommand = value;
            }
        }
    }
}
