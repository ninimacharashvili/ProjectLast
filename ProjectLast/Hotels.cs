namespace ProjectLast
{
    public class Hotels
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
