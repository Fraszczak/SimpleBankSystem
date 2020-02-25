using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class LoginWindowViewModel
    {
        private ICommand showCreateAccountWindowCommand;
        private ICommand loginCommand;
        private ICommand exitCommand;



        public ICommand ShowCreateAccountWindowCommand
        {
            get
            {
                if (this.showCreateAccountWindowCommand == null)
                    this.showCreateAccountWindowCommand = new ShowCreateAccountWindowCommand();

                return this.showCreateAccountWindowCommand;
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                if (this.loginCommand == null)
                    this.loginCommand = new LoginCommand();

                return this.loginCommand;
            }
        }
        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
            }
        }
    







    }
}
