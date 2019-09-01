namespace SimpleBankSystem.ViewModels
{
    using SimpleBankSystem.Commands;
    using System.Windows.Input;

    public sealed partial class MainWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand logoutFromMainWindowCommand;
        private ICommand showInvestmentWindowCommand;
        private ICommand showAccoundWindowCommand;
        private ICommand backCommand;
 

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
            }
        }
        public ICommand LogoutFromMainWindowCommand
        {
            get
            {
                if (this.logoutFromMainWindowCommand == null)
                    this.logoutFromMainWindowCommand = new LogoutFromMainWindowCommand();

                return this.logoutFromMainWindowCommand;
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
        public ICommand BackCommand
        {
            get
            {
                if (this.backCommand == null)
                    this.backCommand = new BackToCommand();

                return this.backCommand;
            }
        }
       
    }
}
