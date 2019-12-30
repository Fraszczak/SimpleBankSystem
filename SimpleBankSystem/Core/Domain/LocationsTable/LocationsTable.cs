using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SimpleBankSystem.Core.Domain
{
    public class LocationsTable
    {
        public LocationsTable()
        {
            this.Jobs = new ObservableCollection<JobTable>();
        }
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        //Klucz obcy
        public virtual ObservableCollection<JobTable> Jobs { get; set; }
    }
}

