using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class InfoRepository : Repository<InfoTable>, IInfoRepository
    {
        public InfoRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
        public string GetData(string whatKindOf)
        {
            var query = from c in PlutoContext.InfoDBSet
                        where c.Name == whatKindOf
                        select c.Description;

            return query.FirstOrDefault();
        }
    }
}
