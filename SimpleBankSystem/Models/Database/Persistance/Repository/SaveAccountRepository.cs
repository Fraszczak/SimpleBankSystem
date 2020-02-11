using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System;
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

        public IEnumerable<SaveAccountTable> GetBallance()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaveAccountTable> GetNames(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaveAccountTable> GetTimes(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaveAccountTable> GetValues(int count)
        { 
            throw new NotImplementedException();
        }
    }
}
