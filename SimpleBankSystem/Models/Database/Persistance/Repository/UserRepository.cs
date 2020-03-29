using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using SimpleBankSystem.ViewModels;

namespace SimpleBankSystem.Persistance.Repository
{
    class UserRepository : Repository<UserTable>, IUserRepository
    {
        public UserRepository(SBSDatabaseContext context)
            : base(context)
        {
        }

       

        public SBSDatabaseContext DatabaseContex
        {
            get { return Context as SBSDatabaseContext; }
        }



        public bool CreateUser(
            string forename, string lastname,
            string title, string phoneNumber, string email,
            string login, string password)
        {
            try
            {
                var userTable = new UserTable
                {
                    Id = Guid.NewGuid(),
                    FirstName = forename,
                    LastName = lastname,
                    Title = title,
                    PhoneNumber = phoneNumber,
                    EmailAddress = email,
                    Login = login,
                    Password = password
                };

                if (true)
                {
                    DatabaseContex.UserTableDbSet.Add(userTable);
                    DatabaseContex.SaveChanges();

                    return true;
                }

                return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Inner exception: " + ex.Message);
                return false;
            }
            finally
            {
                DatabaseContex.Dispose();
            }
        }

        public bool LoginToApp(string login, string password)
        {
            var query = from p in DatabaseContex.UserTableDbSet
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

        public void CreateAccount(string user)
        {
            Dictionary<string, Account> account;

            account = new Dictionary<string, Account>()
            {
                {
                    user,
                    new Account()
                    {
                        Id = Guid.NewGuid(), Balance = 0, DateTime = new DateTime(2000, 10, 10),
                        Type = TypeOfAcount.Main,
                        AccountHistory = new AccountHistoryTable(){Id = Guid.NewGuid(), Value = 100, TransactionDate = new DateTime(2000,11,12), TransactionName = "Car insurance" }
                    }
                }
            };










            //#region Add Account Histor Table
            //var accHistory = new Dictionary<string, AccountHistoryTable>
            //{
            //    { "First transaction", new AccountHistoryTable(){Id = Guid.NewGuid(), Value = 100, TransactionDate = new DateTime(2000,11,12), TransactionName = "Car insurance" , Account = MainAccount[user]}},
            //    { "Second transaction", new AccountHistoryTable(){Id = Guid.NewGuid(), Value = 200, TransactionDate = new DateTime(2003,11,12), TransactionName = "Bike insurance", Account = MainAccount[user]}},
            //    { "Third transaction", new AccountHistoryTable(){Id = Guid.NewGuid(), Value = 150, TransactionDate = new DateTime(2002,11,12), TransactionName = "Home insurance", Account = MainAccount[user]}},
            //    { "Fourth transaction", new AccountHistoryTable(){Id = Guid.NewGuid(), Value = 400, TransactionDate = new DateTime(2001,11,12), TransactionName = "Wife insurance", Account = MainAccount[user]}},

            //};
            //foreach (var single in accHistory.Values)
            //    DatabaseContex.AccountHistoryTableDbSet.AddOrUpdate(t => t.Id, single);
            //#endregion



        }



    }
}
