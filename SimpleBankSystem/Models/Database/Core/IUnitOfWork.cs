using SimpleBankSystem.Core.IRepositories;
using System;

namespace SimpleBankSystem.Core
{
    interface IUnitOfWork : IDisposable
    {
        ILoginToRepository LoginTo { get; }
        IInfoRepository Info { get; }
        IRepository<dynamic> Repository {get;}
        int Complete();
    }
}
