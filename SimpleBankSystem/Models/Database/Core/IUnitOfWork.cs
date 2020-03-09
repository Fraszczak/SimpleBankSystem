using SimpleBankSystem.Core.IRepositories;
using System;

namespace SimpleBankSystem.Core
{
    interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IInfoRepository Info { get; }
        IRepository<dynamic> Repository {get;}
        int Complete();
    }
}
