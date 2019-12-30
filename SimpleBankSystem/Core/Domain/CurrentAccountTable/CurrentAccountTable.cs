using System.Collections.ObjectModel;

namespace SimpleBankSystem.Core.Domain
{
    public class CurrentAccountTable
    {
        private decimal _balance = 0;
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal? Ballance {
            get { return _balance; }
            set { _balance += Value; }
        }

        //ID 
        public System.Guid CurrenciesTableID { get; set; }

        
        
        //Klucz obcy 
        public virtual ObservableCollection<SaveAccountTable> SaveAccount { get; set; }
        public virtual ObservableCollection<CreditCardTable> CreditCard { get; set; }
                //Waluta konta
        public virtual CurrenciesTable Curriences { get; set; }
    }
}

