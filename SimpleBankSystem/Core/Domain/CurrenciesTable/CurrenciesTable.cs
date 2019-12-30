using System.Collections.ObjectModel;

namespace SimpleBankSystem.Core.Domain
{
    public class CurrenciesTable
    {
      
        public System.Guid ID { get; set; }
        public string Name { get; set; }

        public ObservableCollection<CurrentAccountTable> CurrentAccountTable { get; set; }
        // z czasem pomysl nad przelicznikiem
    }

}

