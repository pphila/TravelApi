using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class  DestinationsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }
    
    // GET api/destinations
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get()
    {
      return await _db.Destinations.ToListAsync();
    }
    // Get api/destinations/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      Destination destination = await _db.Destinations.FindAsync(id);
      if (destination == null)
      {
        return NotFound();
      }
      return destination;
    }
    // POST api/destinations
    [HttpPost]
    public async Task<ActionResult<Destination>> Post([FromBody]Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDestination), new {id = destination.DestinationId}, destination);
    }
    // PUT api/destinations/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Destination destination)
    {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }

      _db.Destinations.Update(destination);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool DestinationExists(int id)
    {
      return _db.Destinations.Any(d => d.DestinationId == id);
    }
  }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using TravelApi.Models;

// namespace TravelApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class DestinationsController : ControllerBase
//     {
//         private readonly TravelApiContext _db;

//         public DestinationsController(TravelApiContext db)
//         {
//             _db = db;
//         }

//         // GET: api/Destinations
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<Destination>>> GetDestination()
//         {
//             return await _db.Destinations.ToListAsync();
//         }

//         // GET: api/Destinations/5
//         [HttpGet("{id}")]
//         public async Task<ActionResult<Destination>> GetDestination(int id)
//         {
//             Destination destination = await _db.Destinations.FindAsync(id);

//             if (destination == null)
//             {
//                 return NotFound();
//             }

//             return destination;
//         }

//         // PUT: api/Destinations/5
//         // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutDestination(int id, Destination destination)
//         {
//             if (id != destination.DestinationId)
//             {
//                 return BadRequest();
//             }

//             _db.Entry(destination).State = EntityState.Modified;

//             try
//             {
//                 await _db.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!DestinationExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // POST: api/Destinations
//         // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//         [HttpPost]
//         public async Task<ActionResult<Destination>> PostDestination(Destination destination)
//         {
//             _db.Destinations.Add(destination);
//             await _db.SaveChangesAsync();

//             return CreatedAtAction("GetDestination", new { id = destination.DestinationId }, destination);
//         }

//         // DELETE: api/Destinations/5
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> DeleteDestination(int id)
//         {
//             Destination destination = await _db.Destinations.FindAsync(id);
//             if (destination == null)
//             {
//                 return NotFound();
//             }

//             _db.Destinations.Remove(destination);
//             await _db.SaveChangesAsync();

//             return NoContent();
//         }

//         private bool DestinationExists(int id)
//         {
//             return _db.Destinations.Any(e => e.DestinationId == id);
//         }
//     }
// }
