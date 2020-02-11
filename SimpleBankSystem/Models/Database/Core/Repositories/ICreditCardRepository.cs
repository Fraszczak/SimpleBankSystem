using SimpleBankSystem.Core.Domain;
using System;
using System.Collections.Generic;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICreditCardRepository : IRepository<CreditCardTable>
    {
        IEnumerable<CreditCardTable> GetValues();
        IEnumerable<CreditCardTable> GetTimes();
        IEnumerable<CreditCardTable> GetNames();
        IEnumerable<CreditCardTable> GetBallance();
    }
}
