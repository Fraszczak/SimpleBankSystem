using System;
using System.Linq;
using SimpleBankSystem.Models.Database.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    public interface IOperations
    {
        IQueryable<AccountHistoryTable> GetDataColection();
    }
}