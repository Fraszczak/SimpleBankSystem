using SimpleBankSystem.Core;
using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.Persistance
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly SBSDatabaseContext _context;

        public UnitOfWork(SBSDatabaseContext context)
        {
            _context = context;

            LoginTo = new LoginToRepository(_context);
            Info = new InfoRepository(_context);
            Repository = new Repository<dynamic>(_context);
        }


        public ILoginToRepository LoginTo { get; private set; }
        public IInfoRepository Info { get; private set; }
        public IRepository<dynamic> Repository { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
