using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    class InfoRepository : Repository<InfoTable>, IInfoRepository
    {
        public InfoRepository(SBSDatabaseContext context) : base(context)
        {

        }
        public SBSDatabaseContext SBSDatabaseContext
        {
            get { return Context as SBSDatabaseContext; }
        }
        public string GetData(string whatKindOf)
        {
            var query = from c in SBSDatabaseContext.InfoTableDbSet
                        where c.Name == whatKindOf
                        select c.Description;

            return query.FirstOrDefault();
        }
    }
}
