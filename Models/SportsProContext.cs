using SportsPro.Models;
using Microsoft.EntityFrameworkCore;

namespace SportsPro.Models
{
    public class SportsProContext : DbContext
    {
        public SportsProContext(DbContextOptions<SportsProContext> options)
            : base(options)
        { }

        public DbSet<Products> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                    new Products {
                        ProductId = 1,
                        Code = "TRNY10",
                        Name = "Tournament Master 1.0",
                        YearlyPrice = 4.99,
                        CreatedDateTime = new DateTime(2018, 1, 1)
                    },
                    new Products
                    {
                        ProductId = 2,
                        Code = "LEAG10",
                        Name = "League Scheduler 1.0",
                        YearlyPrice = 4.99,
                        CreatedDateTime = new DateTime(2019, 2, 2)
                    },
                    new Products
                    {
                        ProductId = 3,
                        Code = "LEAGD10",
                        Name = "League Scheduler Deluxe 1.0",
                        YearlyPrice = 7.99,
                        CreatedDateTime = new DateTime(2018, 2, 1)
                    },
                    new Products
                    {
                        ProductId = 4,
                        Code = "DRAFT10",
                        Name = "Draft Manager 1.0",
                        YearlyPrice = 4.99,
                        CreatedDateTime = new DateTime(2018, 1, 2)
                    },
                    new Products
                    {
                        ProductId = 5,
                        Code = "TEAM10",
                        Name = "Team Manager 1.0",
                        YearlyPrice = 4.99,
                        CreatedDateTime = new DateTime(2020, 8, 6)
                    },
                    new Products
                    {
                        ProductId = 6,
                        Code = "TRNY20",
                        Name = "Tournament Master 2.0",
                        YearlyPrice = 5.99,
                        CreatedDateTime = new DateTime(2021, 11, 12)
                    },
                    new Products
                    {
                        ProductId = 7,
                        Code = "DRAFT20",
                        Name = "Draft Manager 2.0",
                        YearlyPrice = 5.99,
                        CreatedDateTime = new DateTime(2020, 5, 4)
                    }
                );
        }
    }
}
