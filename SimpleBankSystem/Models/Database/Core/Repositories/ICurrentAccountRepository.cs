using SimpleBankSystem.Core.Domain;
using System;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICurrentAccountRepository : IRepository<CurrentAccountTable>
    {
        IEnumerable<CurrentAccountTable> GetValues();
        IEnumerable<CurrentAccountTable> GetTimes();
        IEnumerable<CurrentAccountTable> GetNames();
        IEnumerable<CurrentAccountTable> GetBallance();
    }
}
