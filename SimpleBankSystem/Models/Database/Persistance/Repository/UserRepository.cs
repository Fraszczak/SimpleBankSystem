using SimpleBankSystem.Core.IRepositories;
using SimpleBankSystem.Models.Database.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

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

                //var listOfLetter = new List<char>()
                //{
                //    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                //    'm', 'n', 'o', 'p', 'r', 's', 't', 'q', 'u', 'w', 'x', 'y',
                //    'z'
                //};
                //var listOfChar = new List<char>() {
                //    ',', '.', '?', ';', ':', '\'', '\\', '[', ']', '{', '}',
                //    '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-',
                //    '+', '~', '|', '/', '?', '1', '2', '3', '4', '5', '6', '7',
                //    '8', '9', '0'
                //};

                ////var query = from p in DatabaseContex.UserTableDbSet
                ////            select p;

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

                //foreach (var single in listOfChar)
                //{
                //    if (userTable.FirstName.Contains(single) || userTable.FirstName.Length.Equals(0)
                //        || userTable.LastName.Contains(single) || userTable.LastName.Length.Equals(0)
                //        || userTable.Title.Contains(single) || userTable.Title.Length.Equals(0))
                //    {
                //        return false;
                //    }
                //}

                ////Przyda sie jeszcze sprawdzanie zdublowanych loginow
                //foreach (var single in listOfLetter)
                //{
                //    if (userTable.PhoneNumber.Contains(single) || userTable.PhoneNumber.Length.Equals(0)
                //        || userTable.Login.Length.Equals(0))
                //    {
                //        return false;
                //    }
                //}



                DatabaseContex.UserTableDbSet.Add(userTable);
                DatabaseContex.SaveChanges();

                return true;
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




       
    }
}
