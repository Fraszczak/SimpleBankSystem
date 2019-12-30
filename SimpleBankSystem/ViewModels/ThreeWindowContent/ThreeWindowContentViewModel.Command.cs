using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class ThreeWindowContentViewModel
    {
        private ICommand exitCommand;
        private ICommand backCommand;
        private ICommand logoutCommand;
        private ICommand showMainWindowCommand;
        private ICommand showAccoundWindowCommand;
        private ICommand showInvestmentWindowCommand;

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
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
        }
        public ICommand ShowMainWindowCommand
        {
            get
            {
                if (showMainWindowCommand == null)
                    showMainWindowCommand = new ShowMainWindowCommand();
                return this.showMainWindowCommand;
            }
        }
        public ICommand ShowInvestmentWindowCommand
        {
            get
            {
                if (showInvestmentWindowCommand == null)
                    showInvestmentWindowCommand = new ShowInvestmentWindowCommand();
                return this.showInvestmentWindowCommand;
            }
        }
        public ICommand ShowAccountWindowCommand
        {
            get
            {
                if (showAccoundWindowCommand == null)
                    showAccoundWindowCommand = new ShowAccountWindowCommand();
                return this.showAccoundWindowCommand;
            }
        }
        public ICommand LogoutCommand
        {
            get
            {
                if (logoutCommand == null)
                    logoutCommand = new LogoutFromThreeWindowCommand();

                return this.logoutCommand;
            }
        }
    }
}
