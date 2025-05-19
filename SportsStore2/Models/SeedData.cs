using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore2.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "a one-person boat",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Lifejacket",
                        Category = "Watersports",
                        Price = 49
                    },
                    new Product
                    {
                        Name = "Soccer ball",
                        Description = "fifa-approved",
                        Category = "Soccer",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Corner flags",
                        Description = "professional-approved",
                        Category = "Soccer",
                        Price = 30
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "35 000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Cap for thinking",
                        Category = "IDK",
                        Price = 70
                    },
                    new Product
                    {
                        Name = "Unsteady chair",
                        Description = "For naughty people",
                        Category = "IDK",
                        Price = 700
                    },
                    new Product
                    {
                        Name = "Chess",
                        Description = "Chess",
                        Category = "IDK",
                        Price = 100
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
