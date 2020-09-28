using SimpleBankSystem.Core.IRepositories;
using System;

namespace SimpleBankSystem.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IInfoRepository Info { get; }
        IRepository<dynamic> Repository {get;}
        IOperations Operations { get; }
        int Complete();
    }
}
