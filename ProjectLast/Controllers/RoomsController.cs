using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectLast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/rooms/getall
        [HttpGet("getall")]
        public IActionResult GetAllRooms()
        {
            var rooms = _context.Rooms.ToList();
            return Ok(rooms);
        }

        // GET: api/rooms/getroom/{id}
        [HttpGet("getroom/{id}")]
        public IActionResult GetRoomById(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
                return NotFound();
            return Ok(room);
        }

        // GET: api/rooms/getroomtypes
        [HttpGet("getroomtypes")]
        public IActionResult GetRoomTypes()
        {
            var roomTypes = _context.Rooms
                .Select(r => r.RoomTypeId)
                .Distinct()
                .ToList();

            return Ok(roomTypes);
        }
    }
}
