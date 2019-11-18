using System.Collections.Generic;

namespace SimpleBankSystem.Models
{
    public class LocationsTable
    {
        public LocationsTable()
        {
            this.Jobs = new HashSet<JobTable>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<JobTable> Jobs { get; set; }
    }
}

