
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class AccountWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand backToMainWindowCommand;
        private ICommand showInvestmentWindowCommand;
        private ICommand logoutFromAccountWindowCommand;

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
                if (this.backToMainWindowCommand == null)
                    this.backToMainWindowCommand = new BackToCommand();

                return this.backToMainWindowCommand;
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
    }
}
