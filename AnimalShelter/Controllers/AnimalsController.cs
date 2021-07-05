using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        // GET: api/animals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string breed, string color, string size, bool? spayedOrNeutered, float? lowestAge, float? highestAge, string gender)
        {
            var query = _db.Animals.AsQueryable();

            if (lowestAge == null && highestAge != null)
            {
                lowestAge = 0;
            }

            if (lowestAge != null && highestAge == null)
            {
                highestAge = float.PositiveInfinity;
            }

            if (lowestAge != null && highestAge != null)
            {
                query = query.Where(entry => entry.Age >= lowestAge && entry.Age <= highestAge);
            }

            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }

            if (breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }

            if (color != null)
            {
                query = query.Where(entry => entry.Color == color);
            }

            if (size != null)
            {
                query = query.Where(entry => entry.Size == size);
            }

            if (spayedOrNeutered != null)
            {
                query = query.Where(entry => entry.SpayedOrNeutered == spayedOrNeutered.Value);
            }

            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }

            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }      

            return await query.ToListAsync();
        }

        // POST: api/animals
        [HttpPost]
        public async Task<ActionResult<Animal>> Post(Animal animal)
        {
            _db.Animals.Add(animal);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }

        // GET: api/Animals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            Animal animal = await _db.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }
    }
}