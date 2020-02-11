using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBankSystem.Persistance.Repository
{
    public class CurrentAccountRepository : Repository<CurrentAccountTable>, ICurrentAccountRepository
    {
        public CurrentAccountRepository(PlutoContext context) 
            : base(context)
        {
        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public IEnumerable<CurrentAccountTable> GetBallance()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CurrentAccountTable> GetNames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CurrentAccountTable> GetTimes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CurrentAccountTable> GetValues()
        {
            throw new NotImplementedException();
        }
    }
}
