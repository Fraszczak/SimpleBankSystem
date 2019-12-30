using SimpleBankSystem.Core;
using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models;
using SimpleBankSystem.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Persistance
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            CreditCard = new CreditCardRepository(_context);
            CurrentAccount = new CurrentAccountRepository(_context);
            LoginTo = new LoginToRepository(_context);

        }

        public ICreditCardRepository CreditCard { get; private set; }
        public ICurrentAccountRepository CurrentAccount { get; private set; }
        public ILoginToRepository LoginTo { get; private set; }
        public ISaveAccountRepository SaveAccount { get; private set; }

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
