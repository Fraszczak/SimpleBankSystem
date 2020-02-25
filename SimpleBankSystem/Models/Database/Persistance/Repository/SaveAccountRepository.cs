using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class SaveAccountRepository : Repository<SaveAccountTable>, ISaveAccountRepository
    {
        public SaveAccountRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public decimal GetBallance()
        {
            var query = from a in PlutoContext.SaveAccountDbSet
                        select a.Value;
            var sum = 0M;

            foreach (var a in query)
                sum += a;

            return sum;
        }

        public IEnumerable<SaveAccountTable> GetSaveAccountTable()
        {
            return PlutoContext.SaveAccountDbSet.ToList();
        }
    }
}
