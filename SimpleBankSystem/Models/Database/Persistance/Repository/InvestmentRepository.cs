using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.Repositories;

namespace SimpleBankSystem.Persistance.Repository
{
    public class InvestmentRepository : Repository<InvestmentTable>, IInvestmentRepository
    {
        public InvestmentRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
