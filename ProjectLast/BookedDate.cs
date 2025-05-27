namespace ProjectLast
{
    public class BookedDate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomId { get; set; }

        public Room Room { get; set; }
    }
}
