using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turismo.API.Data;

namespace Turismo.API.Controllers
{
        [ApiController]
        [Route("/api/cities")]

        public class CitiesController : ControllerBase
        {

            private readonly DataContext _context;

            public CitiesController(DataContext context)
        {
            _context = context; 

        }
        //Lista de ciudades
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Cities.ToListAsync());

        }
        //Get por parametro --- id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

           var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == id);

            if(city ==  null)
            {
                return NotFound();
            }

            return  Ok(city);

        }
    }
}
