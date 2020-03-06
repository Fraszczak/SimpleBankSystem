using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models.Database.Core.Domain
{
    public class AccountHistoryTable
    {
        
        public System.Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionName { get; set; }

       
        public virtual Account Account { get; set; }

        
    }
}
