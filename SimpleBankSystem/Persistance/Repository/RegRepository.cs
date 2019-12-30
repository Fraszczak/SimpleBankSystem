using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class RegRepository : Repository<RegTable>, IRegRepository
    {
        public RegRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
        public string GetData(string whatKindOf)
        {
            return PlutoContext.RegDbSet.Where(a => a.Name == whatKindOf).Select(a => a.Description).ToString();
        }
    }
}
