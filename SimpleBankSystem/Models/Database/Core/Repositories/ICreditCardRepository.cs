using SimpleBankSystem.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ICreditCardRepository : IRepository<CreditCardTable>
    {
        decimal GetBallance();

    }
}
