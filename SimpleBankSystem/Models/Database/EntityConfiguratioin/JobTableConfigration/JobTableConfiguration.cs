using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.JobConfigration
{
    public class JobTableConfiguration : EntityTypeConfiguration<JobTable>
    {
        public JobTableConfiguration()
        {
            ToTable("JobTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .HasMaxLength(100);

            Property(c => c.Description)
                .HasMaxLength(2000);

         
        }

    }
}
