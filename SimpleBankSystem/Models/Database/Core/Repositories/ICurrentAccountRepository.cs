using SimpleBankSystem.Core.Domain;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICurrentAccountRepository : IRepository<CurrentAccountTable>
    {
        IEnumerable<CurrentAccountTable> GetCurrentAccoutTable();
        decimal GetBallance();
    }
}
