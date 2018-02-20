using Data;
using Objects;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class SampleController : ApiController
    {
        public SampleController()
        {

        }


        public async Task<List<Customer>> GetAllCustomers()
        {
            using (SampleDbContext dbContext = new SampleDbContext())
            {
                return await dbContext.Customers.Select(c => new Customer {
                    
                    FullName = c.FirstName + c.LasttName
                }).ToListAsync();
               
            }
        }
    }
}
