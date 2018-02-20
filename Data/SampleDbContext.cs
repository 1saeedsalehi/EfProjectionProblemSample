using Objects;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Data
{
    public class SampleDbContext : DbContext
    {
        static SampleDbContext()
        {
            Database.SetInitializer<SampleDbContext>(null);
        }
        public SampleDbContext() :base(new SqlConnection(@"Data Source=.;Initial Catalog=SampleAppDb;Persist Security Info=True;User ID=sa;Password=kronos"), contextOwnsConnection: true)
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
