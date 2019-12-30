using SimpleBankSystem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Core
{
    interface IUnitOfWork : IDisposable
    {
        ICreditCardRepository CreditCard { get; }
        ICurrentAccountRepository CurrentAccount { get; }
        ILoginToRepository LoginTo { get; }
        ISaveAccountRepository SaveAccount { get; }
        int Complete();
    }
}
