using SimpleBankSystem.Core;
using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.Persistance
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            CreditCard = new CreditCardRepository(_context);
            SaveAccount = new SaveAccountRepository(_context);
            CurrentAccount = new CurrentAccountRepository(_context);
            LoginTo = new LoginToRepository(_context);
            Info = new InfoRepository(_context);
            Repository = new Repository<SaveAccountRepository>(_context);
        }

        public ICreditCardRepository CreditCard { get; private set; }
        public ISaveAccountRepository SaveAccount { get; private set; }
        public ICurrentAccountRepository CurrentAccount { get; private set; }
        public ILoginToRepository LoginTo { get; private set; }
        public IInfoRepository Info { get; private set; }
        public IRepository<SaveAccountRepository> Repository { get; private set; }
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
