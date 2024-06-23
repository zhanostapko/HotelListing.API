using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Redisson Blue",
                    CountryId = 1,
                    Raiting = 4.5,
                    Address = "Dzirnavu 43",

                },
                new Hotel
                     {
                         Id = 2,
                         Name = "Redisson Blue2",
                         CountryId = 2,
                         Raiting = 4.5,
                         Address = "Dzirnavu 45",

                     }
               );
            modelBuilder.Entity<Country>().HasData(

                new Country
                {
                    Id = 1,
                    Name = "Latvia",
                    ShortCode = "LV"
                },
                new Country
                {
                    Id = 2,
                    Name = "Latvia2",
                    ShortCode = "LVA"
                }
                );
        }
    }
}
