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


        [HttpGet]
        public IActionResult GetAllBookings()
        {
            var bookings = _context.BookedDates.ToList();
            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult BookRoomByType([FromBody] RoomTypeBookingDto dto)
        {
            for (var date = dto.CheckInDate.Date; date < dto.CheckOutDate.Date; date = date.AddDays(1))
            {
                bool alreadyBooked = _context.BookedDates
                    .Any(b => b.RoomTypeId == dto.RoomTypeId && b.Date == date);

                if (alreadyBooked)
                    return BadRequest("Room of this type is already booked on one or more selected dates.");
            }

            for (var date = dto.CheckInDate.Date; date < dto.CheckOutDate.Date; date = date.AddDays(1))
            {
                _context.BookedDates.Add(new BookedDate
                {
                    RoomTypeId = dto.RoomTypeId,
                    Date = date
                });
            }

            _context.SaveChanges();
            return Ok("Booking successful.");
        }


        [HttpDelete("Delete")]
        public IActionResult CancelBooking(int roomTypeId, DateTime checkInDate, DateTime checkOutDate)
        {
            var bookings = _context.BookedDates
                .Where(b => b.RoomTypeId == roomTypeId &&
                            b.Date >= checkInDate.Date &&
                            b.Date < checkOutDate.Date)
                .ToList();

            if (!bookings.Any())
                return NotFound("No bookings found for the given dates and room type.");

            _context.BookedDates.RemoveRange(bookings);
            _context.SaveChanges();

            return Ok("Booking cancelled successfully.");
        }
    }
}
