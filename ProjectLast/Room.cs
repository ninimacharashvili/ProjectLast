using ProjectLast;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLast;

public class Room
{
    [Key]
    public int Id { get; set; }
    public  string? Name { get; set; }

    [ForeignKey(nameof(Hotel))]
    public int HotelId { get; set; }

    public int RoomTypeId { get; set; }

    public decimal PricePerNight { get; set; }

    public int MaximumGuests { get; set; }

    public virtual  Hotels? Hotel { get; set; }

    public virtual List<BookedDate>? BookedDates { get; set; }
}
