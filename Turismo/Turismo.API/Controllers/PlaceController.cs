using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turismo.API.Data;
using Turismo.Shared.Entities;

namespace Turismo.API.Controllers
{
        [ApiController]
        [Route("/api/places")]

        public class PlacesController : ControllerBase
        {

            private readonly DataContext _context;

            public PlacesController(DataContext context)
        {
            _context = context; 

        }
        //Lista de ciudades
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Places.ToListAsync());

        }
        //Get por parametro --- id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

           var place = await _context.Places.FirstOrDefaultAsync(c => c.Id == id);

            if(place ==  null)
            {
                return NotFound();//404
            }

            return  Ok(place);//200

        }
        [HttpPost]

        public async Task<ActionResult> Post(Place place)
        {
            _context.Add(place);
            await _context.SaveChangesAsync();
            return Ok(place);
        }
        [HttpPut]

        public async Task<ActionResult> Put(Place evento)
        {
            _context.Update(evento);
            await _context.SaveChangesAsync();
            return Ok(evento);
        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var filaafectada = await _context.Cities.Where(c => c.Id == id).ExecuteDeleteAsync();

            if (filaafectada==0)
            {
                return NotFound();//404
            }

            return NoContent();//204
        }
    }
}
