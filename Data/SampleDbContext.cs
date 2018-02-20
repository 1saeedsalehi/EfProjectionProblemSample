
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
        public SampleDbContext() :base(new SqlConnection(@"Data Source=.;Initial Catalog=SampleAppDb;Integrated Security=True;"), contextOwnsConnection: true)
        {
            
        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
