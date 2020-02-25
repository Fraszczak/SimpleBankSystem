using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InvestmentsWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand backToCommand;
        private ICommand logoutCommand;
        private ICommand showAccoundWindowCommand;

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
            }
        }
        public ICommand BackToCommand
        {
            get
            {
                if (this.backToCommand == null)
                    this.backToCommand = new BackToCommand();

                return this.backToCommand;
            }
        }
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (this.showAccoundWindowCommand == null)
                    this.showAccoundWindowCommand = new ShowAccountWindowCommand();

                return this.showAccoundWindowCommand;
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                if (this.logoutCommand == null)
                    this.logoutCommand = new LogoutCommand();

                return this.logoutCommand;
            }
        }
    }
}
