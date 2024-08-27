using HotelListing.API.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="Jamaica",
                    ShortName="JM"
                },
                new Country
                {
                    Id = 2,
                    Name="Bahamas",
                    ShortName="BS"
                },
                new Country
                {
                    Id=3,
                    Name="Cayman Islands",
                    ShortName="CI"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel 
                { 
                    Id=1,
                    Name="Marriot",
                    CountryId=1,
                    Rating=4.6
       
                },
                new Hotel
                {
                    Id=2,
                    Name="Taj",
                    CountryId=3,
                    Rating=3.8
                },
                new Hotel
                {
                    Id=3,
                    Name="Lalit",
                    CountryId=2,
                    Rating=4
                }
                );
        }
    }
}
