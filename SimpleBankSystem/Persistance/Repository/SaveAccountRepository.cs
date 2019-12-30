using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
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
        public decimal GetBalance()
        {
            return PlutoContext.CreditCardDbSet.Select(a => a.Ballance).Count();
        }
    }
}
