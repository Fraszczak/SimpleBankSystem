
using SimpleBankSystem.Persistance;
using System.Windows;
using SimpleBankSystem.ViewModels;

namespace SimpleBankSystem.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        public MainWindow()
        {
            InitializeComponent();
            //CurrentAccountTable.ItemsSource = unitOfWork.Operations.GetDataColection();

        }



        //private SBSDatabaseContext _context = new SBSDatabaseContext();

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //    System.Windows.Data.CollectionViewSource currentAccountViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("currentAccountViewSource")));

        //    currentAccountViewSource.Source = _context.CurrentAccountDbSet.Local;

        //}
        //protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        //{
        //    base.OnClosing(e);

        //    _context.Dispose();
        //}

        
    }
}
