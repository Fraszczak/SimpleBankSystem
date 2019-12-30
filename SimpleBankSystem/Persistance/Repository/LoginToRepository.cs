using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Core.IRepositories;
using System;
using System.Linq;
using System.Windows;

namespace SimpleBankSystem.Persistance.Repository
{
   public class LoginToRepository : Repository<LoginToTable>, ILoginToRepository
    {
        public LoginToRepository(PlutoContext context) : base(context)
        {

        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public void CreateUser(string login, string password)
        {
            var table = new LoginToTable
            {
                ID = Guid.NewGuid(),
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
            //SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE ([user] = @user)", conn);
            //check_User_Name.Parameters.AddWithValue("@user", txtBox_UserName.Text);
            //int UserExist = (int)check_User_Name.ExecuteScalar();

            //if (UserExist > 0)
            //{
            //    //Username exist
            //}
            //else
            //{
            //    //Username doesn't exist.
            //}

        }
    }
}
