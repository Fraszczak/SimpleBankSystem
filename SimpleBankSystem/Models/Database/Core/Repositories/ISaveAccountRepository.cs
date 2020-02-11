using SimpleBankSystem.Core.Domain;
using System;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ISaveAccountRepository : IRepository<SaveAccountTable>
    {
        IEnumerable<SaveAccountTable> GetValues(int count);
        IEnumerable<SaveAccountTable> GetTimes(int count);
        IEnumerable<SaveAccountTable> GetNames(int count);
        IEnumerable<SaveAccountTable> GetBallance();
    }
}
