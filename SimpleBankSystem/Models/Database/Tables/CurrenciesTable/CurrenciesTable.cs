using System.Collections.Generic;

namespace SimpleBankSystem.Models
{
    public class CurrenciesTable
    {
      
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<CurrentAccountTable> CurrentAccountTable { get; set; }
        // z czasem pomysl nad przelicznikiem
    }

}

