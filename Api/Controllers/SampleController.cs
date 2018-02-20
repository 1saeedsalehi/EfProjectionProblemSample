extern alias DataAlias;
extern alias DtoAlias;
using DataAlias::Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        
        [HttpGet]
        public async Task<List<DtoAlias.Objects.Customer>> GetAllCustomers()
        {
            using (SampleDbContext dbContext = new SampleDbContext())
            {
                return await dbContext.Customers.Select(c => new DtoAlias.Objects.Customer
                {
                    FullName = string.Concat(c.FirstName,c.LasttName)
                    
                }).ToListAsync();

            }
        }


    }
}
