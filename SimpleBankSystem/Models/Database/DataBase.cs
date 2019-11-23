using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32.SafeHandles;

namespace SimpleBankSystem.Models
{
    public class DataBase
    {

        private static DataBase instance = null;

        private static readonly object padLock = new object();
        //private static string _query;
        //private static readonly string ConncectionString = SimpleBankSystem.Properties.Settings.Default.SimpleBankSystemDataBaseConnectionString;
        //private static int whichAccount;
        //private static SqlConnection connection = null;


        public static DataBase Instance
        {
            get
            {
                lock (padLock)

                {
                    if (instance == null)
                        instance = new DataBase();

                    return instance;
                }
            }
        }

       public bool LoginToApp(string login, string password)
        {
            using (var context = new PlutoContext())
            {
                MessageBox.Show("Jestem tutaj");
                var query = from p in context.LoginDbSet
                            where p.Login == login && p.Password == password
                            select p;

                
                if (query.Any())
                    return true;
                else
                {
                    MessageBox.Show("Podales zle pasy");
                    return false;
                }

                
            }
        }
    }

}

