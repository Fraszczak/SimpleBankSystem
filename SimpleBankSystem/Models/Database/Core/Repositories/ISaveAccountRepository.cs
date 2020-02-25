using SimpleBankSystem.Core.Domain;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ISaveAccountRepository : IRepository<SaveAccountTable>
    {
        IEnumerable<SaveAccountTable> GetSaveAccountTable();
        decimal GetBallance();
    }
}
