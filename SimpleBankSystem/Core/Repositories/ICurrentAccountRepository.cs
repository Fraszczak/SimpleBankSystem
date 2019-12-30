using SimpleBankSystem.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICurrentAccountRepository : IRepository<CurrentAccountTable>
    {
        decimal GetBallance();
    }
}
