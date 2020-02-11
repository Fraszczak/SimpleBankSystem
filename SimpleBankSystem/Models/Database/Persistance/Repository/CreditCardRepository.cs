using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class CreditCardRepository : Repository<CreditCardTable>, ICreditCardRepository
    {
        public CreditCardRepository(PlutoContext context) 
            :  base(context)
        {
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public IEnumerable<CreditCardTable> GetBallance()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreditCardTable> GetNames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreditCardTable> GetTimes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreditCardTable> GetValues()
        {
            throw new NotImplementedException();
        }
    }
}
