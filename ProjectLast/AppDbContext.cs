using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProjectLast
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<BookedDate> BookedDates { get; set; }
    }



  
}