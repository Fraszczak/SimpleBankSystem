using System;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.Core.Domain
{
    public class CurrentAccountTable
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DataTime { get; set; }
        public decimal Value { get; set; }

        ////ID 
        //public System.Guid CurrenciesTableID { get; set; }



        ////Klucz obcy 
        //public virtual ObservableCollection<SaveAccountTable> SaveAccount { get; set; }
        //public virtual ObservableCollection<CreditCardTable> CreditCard { get; set; }



    }
}

