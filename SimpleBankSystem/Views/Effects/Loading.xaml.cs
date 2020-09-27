using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleBankSystem.Extras
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window, IDisposable
    {

        public Action Worker { get; private set; }
        public Loading(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
        }
        private void WindowIsLoad(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void Dispose() { }
    }
}
