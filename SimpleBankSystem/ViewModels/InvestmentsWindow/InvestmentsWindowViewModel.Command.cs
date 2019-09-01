
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class InvestmentsWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand backToMainWindowCommand;
        private ICommand showAccoundWindowCommand;
        private ICommand logoutFromInvestmenWindowCommand;

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
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (showAccoundWindowCommand == null)
                    this.showAccoundWindowCommand = new ShowAccountWindowCommand();

                return this.showAccoundWindowCommand;
            }
        }
        public ICommand LogoutFromInvestmentWindowCommand
        {
            get
            {
                if (this.logoutFromInvestmenWindowCommand == null)
                    this.logoutFromInvestmenWindowCommand = new LogoutFromInvestmentWindowCommand();

                return this.logoutFromInvestmenWindowCommand;
            }
        }
    }
}
