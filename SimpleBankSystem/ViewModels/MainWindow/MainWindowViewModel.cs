using System.Windows;

namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            WindowState = WindowState.Minimized;
            //this.DataContext = new CurrentAccountViewModel();
           
        }

        public WindowState WindowState { get; }
    }

   
}