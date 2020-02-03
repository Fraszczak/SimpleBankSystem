using System;

namespace SimpleBankSystem.Core.Domain
{
    public class SaveAccountTable
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DataTime { get; set; }
        public decimal Value { get; set; }

        //public System.Guid CurrentAccountID { get; set; }
        //public virtual CurrentAccountTable CurrentAccount { get; set; }


    }
}

