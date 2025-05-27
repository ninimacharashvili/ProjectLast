using ProjectLast;

namespace ProjectLast
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal PricePerNight { get; set; }
        public bool Available { get; set; }
        public int MaximumGuests { get; set; }

        public Hotels Hotel { get; set; }
        public List<BookedDate> BookedDates { get; set; }
    }
}
