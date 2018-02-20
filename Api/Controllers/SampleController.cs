extern alias DtoAlias;
extern alias EntityAlias;

using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using DtoAlias::Objects;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        
        [HttpGet]
        public async Task<List<Customer>> GetAllCustomers()
        {
            using (SampleDbContext dbContext = new SampleDbContext())
            {
                return await dbContext.Set<EntityAlias.Objects.Customer>().Select(c => new Customer
                {
                    Id = c.Id,
                    FullName = string.Concat(c.FirstName,c.LasttName)
                    
                    
                }).ToListAsync();

            }
        }


    }
}
