using System;

namespace SimpleBankSystem.Core.Domain
{
    public class CreditCardTable
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DataTime { get; set; }
        public decimal Value { get; set; }
        

       
        //public System.Guid CurentAccountID { get; set; }

        ////klucz obcy
        //public virtual CurrentAccountTable CurrentAccount { get; set; }
    }

}

