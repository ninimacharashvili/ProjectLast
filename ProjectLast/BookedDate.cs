using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLast
{
    public class BookedDate
    {
        [Key]
        public int Id { get; set; }
        public int RoomTypeId { get; set; }

        public DateTime Date { get; set; }


        //public Room Room { get; set; }
    }
}
