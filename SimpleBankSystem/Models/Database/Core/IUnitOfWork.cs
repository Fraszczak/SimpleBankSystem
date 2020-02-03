using SimpleBankSystem.Core.IRepositories;
using System;

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
