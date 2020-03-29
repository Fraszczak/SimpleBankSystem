using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using SimpleBankSystem.Persistance;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class CreateAccountWindowViewModel 
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _createAccountWindowTitle = unitOfWork.Info.GetData("CreateAccountWindowTitle");

        public string CreateAccountWindowTitle
        {
            get => _createAccountWindowTitle;
            set => OnPropertyChanged("CreateAccountWindowTitle");
        }

        private ICommand _command1;
        public ICommand command1 => _command1 ?? (_command1 = new RelayCommand(() => CreateUser(), () => HasErrors ));

        public void CreateUser()
        {

            MessageBox.Show(" --- ___ --- ");
        }

      

    }
}
