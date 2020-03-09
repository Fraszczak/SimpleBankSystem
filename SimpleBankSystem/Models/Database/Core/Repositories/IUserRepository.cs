using SimpleBankSystem.Models.Database.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface IUserRepository : IRepository<UserTable>
    {
        bool CreateUser(
            string forename, string lastname,
            string title, string phoneNumber, string email,
            string login, string password);
        bool LoginToApp(string login, string password);
    }
}
