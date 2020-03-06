using SimpleBankSystem.Models.Database.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface ILoginToRepository : IRepository<LoginToTable>
    {
        void CreateUser(string login, string password);
        bool LoginToApp(string login, string password);
    }
}
