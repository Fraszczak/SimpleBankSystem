using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;

namespace SimpleBankSystem.Persistance.Repository
{
    public class Operations : Repository<AccountHistoryTable>, IOperations
    {

        public Operations(SBSDatabaseContext context)
            : base(context)
        {
        }

        public SBSDatabaseContext DatabaseContex => Context as SBSDatabaseContext;

        public IQueryable<AccountHistoryTable> GetDataColection()
        {
            var query = from p in DatabaseContex.AccountHistoryTableDbSet
                select p;

            return query;
        }

    }
}