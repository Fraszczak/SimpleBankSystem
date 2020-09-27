using System;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.Models.Database.Core.Domain
{
    public class AccountHistoryTable
    {
        public System.Guid Id { get; set; }
        public decimal Price { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionName { get; set; }


    }
}
