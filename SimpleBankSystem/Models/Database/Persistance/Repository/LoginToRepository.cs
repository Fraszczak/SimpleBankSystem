using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;
using System;
using System.Linq;
using System.Windows;

namespace SimpleBankSystem.Persistance.Repository
{
    class LoginToRepository : Repository<LoginToTable>, ILoginToRepository
    {
        public LoginToRepository(SBSDatabaseContext context) 
            : base(context)
        {
        }
        public SBSDatabaseContext PlutoContext
        {
            get { return Context as SBSDatabaseContext; }
        }

        public void CreateUser(string login, string password)
        {
            var table = new LoginToTable
            {
                Id = Guid.NewGuid(),
                Login = login,
                Password = password
            };
            

            //Tylko wtedy po co UnitOfWork ??

            PlutoContext.LoginDbSet.Add(table);
            PlutoContext.SaveChanges();
        }

        public bool LoginToApp(string login, string password)
        {
            var query = from p in PlutoContext.LoginDbSet
                        where p.Login == login && p.Password == password
                        select p;


            if (query.Any())
                return true;
            else
            {
                MessageBox.Show("Incorrect login or password");
                return false;
            }
            

        }
    }
}
