using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectLast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/booking
        [HttpGet]
        public IActionResult GetAllBookings()
        {
            var bookings = _context.BookedDates.ToList();
            return Ok(bookings);
        }

        // POST: api/booking
        [HttpPost]
        public IActionResult CreateBooking([FromBody] BookedDate booking)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == booking.RoomId);

            if (room == null)
                return NotFound("Room not found.");

            if (room.BookedDates == null)
                room.BookedDates = new List<BookedDate>();

            room.BookedDates.Add(booking);
            room.Available = false;

            _context.SaveChanges();

            return Ok(booking);
        }

        // DELETE: api/booking/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _context.BookedDates.FirstOrDefault(b => b.Id == id);

            if (booking == null)
                return NotFound("Booking not found.");

            _context.BookedDates.Remove(booking);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
