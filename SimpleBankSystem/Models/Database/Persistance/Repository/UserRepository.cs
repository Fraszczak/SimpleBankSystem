using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Sockets;
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
                //createAccountHistory();

                var accountHistory = new AccountHistoryTable
                {
                    Id = Guid.NewGuid(),
                    TransactionDate = DateTime.Today,
                    TransactionName = "Przykładowa transakcja",
                    Price = 100
                };
                DatabaseContex.AccountHistoryTableDbSet.Add(accountHistory);
                DatabaseContex.SaveChanges();

                var user = new UserTable
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
                DatabaseContex.UserTableDbSet.Add(user);
                DatabaseContex.SaveChanges();


                if (createAccount(accountHistory.Id, user.Id))
                {
                    return true;
                }
                
                

                return false;
            }
            catch (EntitySqlException ex)
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

        //public void createAccountHistory()
        //{
        //    var accountHistory = new AccountHistoryTable
        //    {
        //        Id = Guid.NewGuid(),
        //        TransactionDate = DateTime.Today,
        //        TransactionName = "Przykładowa transakcja",
        //        Price = 100
        //    };
        //    DatabaseContex.AccountHistoryTableDbSet.Add(accountHistory);
        //    DatabaseContex.SaveChanges();
        //}

        public bool createAccount(Guid AccountHistoryId, Guid UserId)
        {

            var account = new Account
            {
                Balance = 1000.0M,
                Id = Guid.NewGuid(),
                AccountHistory = DatabaseContex.AccountHistoryTableDbSet.Find(AccountHistoryId),
                AccountHistoryId = DatabaseContex.AccountHistoryTableDbSet.Find(AccountHistoryId).Id,
                Currency = "PLN",
                Users = DatabaseContex.UserTableDbSet.Find(UserId),
                UserTableId = DatabaseContex.UserTableDbSet.Find(UserId).Id
            };


            if (DatabaseContex.AccountDbSet.Any().Equals(account))
            {
                return false;
            }

            DatabaseContex.AccountDbSet.Add(account);
            DatabaseContex.SaveChanges();

            return true;

        }

        //public void CreateAccount(UserTable user)
        //{
        //  try
        //  {
        //      var userID = user.Id;
        //      //var accountHistory = from p in DatabaseContex.AccountHistoryTableDbSet
        //      //    where p.UserTableId == userID
        //      //    select p;

        //                     var account = new Account()
        //        {
        //            Id = Guid.NewGuid(),
        //            Balance = 1000,
        //            DateTime = new DateTime(2000, 10, 10),
        //            Type = TypeOfAcount.Main,
        //            UserTableId = userID,
        //            AccountHistory = new AccountHistoryTable() {},
        //            User = user

        //        };

        //            DatabaseContex.AccountDbSet.Add(account);
        //            DatabaseContex.SaveChanges();

        //    }
        //    catch (EntitySqlException e)
        //    {
        //        MessageBox.Show(e.ToString());
        //        throw;
        //    }
        //  finally
        //  {
        //      DatabaseContex.Dispose();
        //  }
        //}

        //private void CreateAccountHistory(Account account, Guid userId)
        //{

        //    try
        //    {
        //        var accountHistory = new AccountHistoryTable()
        //        {
        //            Id = Guid.NewGuid(),
        //            Value = 100,
        //            TransactionDate = new DateTime(2000, 11, 12),
        //            TransactionName = "Przykładowa transakcja",
        //            Account = account,
        //            UserTableId = userId
        //        };

        //        DatabaseContex.AccountHistoryTableDbSet.Add(accountHistory);
        //        DatabaseContex.SaveChanges();
        //    }
        //    catch (EntitySqlException e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //    finally
        //    {
        //        DatabaseContex.Dispose();
        //    }
        //}

        ////#region Add Account Histor Table
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

