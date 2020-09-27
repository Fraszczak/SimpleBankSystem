using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models.Database.Core.Domain
{
    public class Account
    {
        public Guid Id { get; set; }
        public decimal? Balance { get; set; }
        public string Currency { get; set; }
       
        
        public virtual AccountHistoryTable AccountHistory { get; set; }
        public virtual UserTable Users { get; set; }

        public virtual Guid UserTableId { get; set; }
        public virtual Guid AccountHistoryId { get; set; }

    }
}
