
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class AccountWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand backToCommand;
        private ICommand showInvestmentWindowCommand;
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
        public ICommand LogoutCommand
        {
            get
            {
                if (this.logoutCommand == null)
                    this.logoutCommand = new LogoutCommand();

                return this.logoutCommand;
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
