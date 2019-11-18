using System.Collections.Generic;

namespace SimpleBankSystem.Models
{
    public class CurrentAccountTable
    {
     
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal? Ballance { get; set; }

        public int? CurrenciesTableID { get; set; }
        public CurrenciesTable Curriences { get; set; }

        public ICollection<SaveAccountTable> SaveAccount { get; set; }
        
        public ICollection<CreditCardTable> CreditCard { get; set; }
    }
}

