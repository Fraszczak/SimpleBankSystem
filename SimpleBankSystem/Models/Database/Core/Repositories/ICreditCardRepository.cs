using SimpleBankSystem.Core.Domain;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICreditCardRepository : IRepository<CreditCardTable>
    {
        IEnumerable<CreditCardTable> GetSaveAccountTable();
        decimal GetBallance();
    }
}
