
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class AccountWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand showMainWindowCommand;
        private ICommand showInvestmentWindowCommand;
        private ICommand logoutFromAccountWindowCommand;
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
        public ICommand BackToMainWindowCommand
        {
            get
            {
                if (this.showMainWindowCommand == null)
                    this.showMainWindowCommand = new BackToCommand();

                return this.showMainWindowCommand;
            } 
        }
        public ICommand ShowInvestmentWindowCommand
        {
            get
            {
                if (this.showInvestmentWindowCommand == null)
                    this.showInvestmentWindowCommand = new ShowInvestmentWindowCommand();

                return this.showInvestmentWindowCommand;
            }
            private set
            {
                showInvestmentWindowCommand = value;
            }
        }
        public ICommand LogoutFromAccountWindowCommand
        {
            get
            {
                if (this.logoutFromAccountWindowCommand == null)
                    this.logoutFromAccountWindowCommand = new LogoutFromAccountWindowCommand();

                return this.logoutFromAccountWindowCommand;
            }
        }
        public ICommand ShowAccoundWindowCommand
        {
            get
            {
                if (showAccoundWindowCommand == null)
                    showAccoundWindowCommand = new ShowAccountWindowCommand();

                return showAccoundWindowCommand;
            }
        }
    }

}
