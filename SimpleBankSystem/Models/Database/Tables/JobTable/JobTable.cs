using System.Collections.Generic;

namespace SimpleBankSystem.Models
{
    public class JobTable
    {
        public JobTable()
        {
            this.Locations = new HashSet<LocationsTable>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocationsTable> Locations { get; set; }
    }
}

