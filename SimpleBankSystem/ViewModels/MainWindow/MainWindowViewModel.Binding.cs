
using SimpleBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBankSystem.ViewModels
{

    public sealed partial class MainWindowViewModel
    {
        private string mainWindowTitle = "SimpleBankSystem";
        public string MainWindowTitle
        {
            get
            {
                return this.mainWindowTitle;
            }
            set
            {
                this.mainWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

        //public decimal? BallanceCounter(IQueryable value)
        //{

            
        //    using (var context = new PlutoContext())
        //    {

        //    }




        //        return result;
        //}

        //public void fillMainWindow()
        //{
        //    using (var context = new PlutoContext())
        //    {
        //        var table = new List<CreditCardTable> {

        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "abc", Value = 1143, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "bca", Value = 11234, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "asd", Value = 1123, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "qwer", Value = 1021, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "qazsw", Value = 423, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "rewq", Value = 30, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "qazxswedcc", Value = 1230, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) },
        //            new CreditCardTable{ ID = Guid.NewGuid(), Name = "rewqasdf", Value = 5230, Ballance = BallanceCounter(context.CreditCardDbSet.Select(c=>c.Value)) }
        //        };

        //        context.CreditCardDbSet.AddRange(table);
        //        context.SaveChanges();

        //    }
        //}
    }
}

//var query = from b in db.Blogs
//            orderby b.Name
//            select b;

//Console.WriteLine("All blogs in the database:");
//            foreach (var item in query)
//            {
//                Console.WriteLine(item.Name);
//            }