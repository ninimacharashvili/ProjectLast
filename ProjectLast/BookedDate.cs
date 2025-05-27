using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLast
{
    public class BookedDate
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public Room Room { get; set; }
    }
}
