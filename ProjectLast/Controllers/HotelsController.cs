using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectLast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
            private readonly AppDbContext _context;

            public HotelsController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet("getall")]
            public IActionResult GetAllHotels()
            {
                var hotels = _context.Hotels.ToList();
                return Ok(hotels);
            }

            [HttpGet("gethotel/{id}")]
            public IActionResult GetHotelById(int id)
            {
                var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
                if (hotel == null)
                    return NotFound();
                return Ok(hotel);
            }

            [HttpGet("gethotels")]
            public IActionResult GetHotels()
            {
                var hotels = _context.Hotels.ToList();
                return Ok(hotels);
            }

            
            [HttpGet("getcities")]
            public IActionResult GetCities()
            {
                var cities = _context.Hotels.Select(h => h.City).Distinct().ToList();
                return Ok(cities);
            }
        
    }
}
