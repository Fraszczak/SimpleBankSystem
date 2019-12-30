namespace SimpleBankSystem.Core.Domain
{
    public class CreditCardTable
    {

        private decimal? _balance = 0;

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal? Ballance {
            get { return _balance; }
            set { _balance -= Value; }
        }

       
        public System.Guid CurentAccountID { get; set; }

        //klucz obcy
        public virtual CurrentAccountTable CurrentAccount { get; set; }
    }

}

