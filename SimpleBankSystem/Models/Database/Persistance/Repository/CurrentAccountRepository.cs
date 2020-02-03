using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class CurrentAccountRepository : Repository<CurrentAccountTable>, ICurrentAccountRepository
    {
        public CurrentAccountRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public decimal GetBallance()
        {
            throw new System.NotImplementedException();
        }
        //public decimal GetBallance()
        //{
        //    //return PlutoContext.CreditCardDbSet.Select(a => a.Ballance).Count();
        //}
    }
}
