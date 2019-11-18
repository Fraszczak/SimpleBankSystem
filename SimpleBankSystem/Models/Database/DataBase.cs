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

        //public void Execute(int )
        //{

        //    using (var context = new PlutoContext())
        //    {
        //       // context.RegDbSet.AsNoTracking().Select( a => (new ))
        //    }
        //}
    }

}

