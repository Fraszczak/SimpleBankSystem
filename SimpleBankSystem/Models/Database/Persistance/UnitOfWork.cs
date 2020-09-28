using SimpleBankSystem.Core;
using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SBSDatabaseContext _context;

        public UnitOfWork(SBSDatabaseContext context)
        {
            _context = context;

            UserRepository = new UserRepository(_context);
            Info = new InfoRepository(_context);
            Repository = new Repository<dynamic>(_context);
            Operations = new Operations(_context);
        }


        public IUserRepository UserRepository { get; }
        public IInfoRepository Info { get; }
        public IRepository<dynamic> Repository { get; }
        public IOperations Operations { get; }

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
