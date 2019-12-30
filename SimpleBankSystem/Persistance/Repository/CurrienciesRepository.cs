using SimpleBankSystem.Core.Repositories;
using SimpleBankSystem.Models;
using System;

namespace SimpleBankSystem.Persistance.Repository
{
    public class CurrienciesRepository : Repository<CurrienciesRepository>, ICurrienciesRepository
    {
        public CurrienciesRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public string GetCurriencies()
        {
            return PlutoContext.CurrenciesDbSet.Find(1).Name.ToString();
        }
    }
}
