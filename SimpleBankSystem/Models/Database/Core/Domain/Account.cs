using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models.Database.Core.Domain
{
    public class Account
    {

        public Guid Id { get; set; }
        public decimal? Balance { get; set; }
        public DateTime DateTime { get; set; }
        
        public  TypeOfAcount Type { get; set; }
       
        
        public virtual AccountHistoryTable AccountHistory { get; set; }
        
       
        public virtual UserTable User { get; set; }
       

        
    }
}
