using SimpleBankSystem.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ISaveAccountRepository : IRepository<SaveAccountTable>
    {
        decimal GetBalance();
    }
}
