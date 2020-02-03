using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InfoViewModel
    {
        private ICommand exitCommand;
        private ICommand backToCommand;
        private ICommand logoutCommand;
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
        public ICommand BackToCommand
        {
            get
            {
                if (this.backToCommand == null)
                    this.backToCommand = new BackToCommand();

                return this.backToCommand;
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
                    logoutCommand = new LogoutCommand();

                return this.logoutCommand;
            }
        }
    }
}
