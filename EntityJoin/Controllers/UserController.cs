using EntityJoin.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EntityJoin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DemoDbContext _dbContext;

        public UserController(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllUser()
        {
            //var result = await _dbContext.Laptops
            //    .Include(x => x.User)
            //    .ThenInclude(x => x.Laptops).ToListAsync();
            //return Ok(result);
            var result = await _dbContext.Users.ToListAsync();
            return Ok(result);


            /*var result = await _context.Persons
                .Include(x => x.PersonCars)
                .ThenInclude(x => x.Cars)
                .ToListAsync();
             */
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUser()
        {
            var result = await _dbContext.Laptops
                .Include(x => x.User)
                .ThenInclude(x => x.Laptops)
                .ToListAsync();
            return Ok(result);
                //var result = await _context.Cars
                //    .Include(x => x.Person)
                //    .ThenInclude(x => x.Cars)
                //    .ToListAsync();
                //.FirstOrDefaultAsync(x => x.Name == "Rustam");
        }
    }
}
