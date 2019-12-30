using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.Core.Domain
{
    public class JobTable
    {
        public JobTable()
        {
            this.Locations = new ObservableCollection<LocationsTable>();
        }
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Klucz obcy
        public virtual ObservableCollection<LocationsTable> Locations { get; set; }
    }
}

