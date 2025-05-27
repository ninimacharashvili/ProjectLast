using System.ComponentModel.DataAnnotations;

namespace ProjectLast
{
    public class Hotels
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public  virtual List<Room> Rooms { get; set; }
    }
}
