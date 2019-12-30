using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.Core.Repositories
{
    interface ICurrienciesRepository : IRepository<CurrienciesRepository>
    {
        string GetCurriencies();
    }
}
