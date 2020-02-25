using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
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

        public decimal GetBallance()
        {
            var query = from a in PlutoContext.CreditCardDbSet
                        select a.Value;
            var sum = 0M;

            foreach (var a in query)
                sum += a;

            return sum;
        }

        public IEnumerable<CreditCardTable> GetSaveAccountTable()
        {
            return PlutoContext.CreditCardDbSet.ToList();
        }
    }
}
