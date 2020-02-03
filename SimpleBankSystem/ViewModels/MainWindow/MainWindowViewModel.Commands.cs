namespace SimpleBankSystem.ViewModels
{
    using SimpleBankSystem.Commands;
    using System.Windows.Input;

    public sealed partial class MainWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand logoutCommand;
        private ICommand showInvestmentWindowCommand;
        private ICommand showAccoundWindowCommand;
        private ICommand backCommand;
        private ICommand showInfoWindowCommand;
        private ICommand transferFoundsCommand;
     

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
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
        public ICommand ShowInfoWindowCommand
        {
            get
            {
                if (showInfoWindowCommand == null)
                    showInfoWindowCommand = new ShowInfoWindowCommand();
                return this.showInfoWindowCommand;
            }
        }

        public ICommand TransferFoundsCommand
        {
            get
            {
                if (transferFoundsCommand == null)
                    transferFoundsCommand = new TranserFounds();
                return this.transferFoundsCommand;
            }
        }
      
    }
}
