using System;
using System.Linq;

namespace ProjectLast
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            var hotels = new[]
            {
                new Hotels
                {
                    Name = "The Biltmore Hotel Tbilisi",
                    Address = "29 Rustaveli Ave, Tbilisi, 0108",
                    City = "Tbilisi",
                },
                new Hotels
                {
                    Name = "Courtyard by Marriott Tbilisi",
                    Address = "4 Freedom Square, Tbilisi, 0105",
                    City = "Tbilisi",
                },
                new Hotels
                {
                    Name = "Radisson Blu Iveria Hotel Tbilisi",
                    Address = "1 Republic Square, Tbilisi, 0108",
                    City = "Tbilisi",
                }
            };

            context.Hotels.AddRange(hotels);
            context.SaveChanges();

  
            var rooms = new[]
            {
                new Room
                {
                    Name = "Suite",
                    HotelId = hotels[0].Id,
                    RoomTypeId = 1,
                    PricePerNight = 250,
                    MaximumGuests = 4,
                    BookedDates = new System.Collections.Generic.List<BookedDate>
                    {
                        new BookedDate { Date = DateTime.Today.AddDays(2) },
                        new BookedDate { Date = DateTime.Today.AddDays(3) },
                    }
                },
                new Room
                {
                    Name = "Standard",
                    HotelId = hotels[1].Id,
                    RoomTypeId = 2,
                    PricePerNight = 150,
                    MaximumGuests = 2,
                    BookedDates = new System.Collections.Generic.List<BookedDate>()
                },
                new Room
                {
                    Name = "Deluxe",
                    HotelId = hotels[2].Id,
                    RoomTypeId = 3,
                    PricePerNight = 300,
                    MaximumGuests = 3,
                    BookedDates = new System.Collections.Generic.List<BookedDate>
                    {
                        new BookedDate { Date = DateTime.Today.AddDays(5) }
                    }
                }
            };

            context.Rooms.AddRange(rooms);
            context.SaveChanges();
        }
    }
}