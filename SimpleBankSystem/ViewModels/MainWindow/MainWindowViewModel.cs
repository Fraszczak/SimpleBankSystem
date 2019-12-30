

using System.Windows;

namespace SimpleBankSystem.ViewModels
{
   
    public sealed partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            WindowState = WindowState.Minimized;
        }

        public WindowState WindowState { get; }
    }
}