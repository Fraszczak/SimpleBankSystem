
using SimpleBankSystem.Commands;
using System.Windows.Input;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class CreateAccountWindowViewModel
    {
        private ICommand exitCommand;
        private ICommand backCommand;
        private ICommand registryCommand;

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                    this.exitCommand = new ExitCommand();

                return this.exitCommand;
            }
            private set => ExitCommand = value;
        }
        public ICommand BackCommand
        {
            get
            {
                if (this.backCommand == null)
                    this.backCommand = new LogoutCommand();

                return this.backCommand;
            }
            private set => BackCommand = value;
        }

        public ICommand RegistryCommand
        {
            get
            {
                if (this.registryCommand == null)
                    this.registryCommand = new RegistryCommand();

                return this.registryCommand;
            }
            private set => RegistryCommand = value;
        }
    }
}
