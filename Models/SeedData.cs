using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WEB315_Assignments_ThemeCricket.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ThemeCricketContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ThemeCricketContext>>()))
            {
                
                if (context.ThemeCricket.Any())
                {
                    return;   // DB has been seeded
                }

                context.ThemeCricket.AddRange(
                    new ThemeCricket
                    {
                        StadiumName = "Wankhede Stadium",
                        BookingDate = DateTime.Parse("2023-03-04"),
                        City = "Mumbai",
                        State = "Maharashtra",
                        Price = 3500,
                        Capacity = 90000,
                        FirstMatch = "India Vs Pakistan"
                    },

                    new ThemeCricket
                    {
                        StadiumName = "Eden Park Stadium",
                        BookingDate = DateTime.Parse("2023-03-07"),
                        City = "Auckland",
                        State = "New Zealand",
                        Price = 2800,
                        Capacity = 75000,
                        FirstMatch = "West Indies Vs New Zealand"
                    },

                    new ThemeCricket
                    {
                        StadiumName = "Galle International Stadium",
                        BookingDate = DateTime.Parse("2023-03-11"),
                        City = "Galle",
                        State = "Sri Lanka",
                        Price = 2200,
                        Capacity = 40000,
                        FirstMatch = "Bangladesh Vs Sri Lanka"

                    },
                    

                    new ThemeCricket
                    {
                        StadiumName = "Cape Town",
                        BookingDate = DateTime.Parse("2023-03-14"),
                        City = "Cape Town",
                        State = "South Africa",
                        Price = 2700,
                        Capacity = 60000,
                        FirstMatch = "Zimbabwe Vs South Africa"
                    },
                    

                    new ThemeCricket
                    {
                        StadiumName = "Lords Stadium",
                        BookingDate = DateTime.Parse("2023-03-18"),
                        City = "London",
                        State = "England",
                        Price = 3200,
                        Capacity = 80000,
                        FirstMatch = "Afganistan Vs England"
                    },
                    

                    new ThemeCricket
                    {
                        StadiumName = "Melbourn Stadium",
                        BookingDate = DateTime.Parse("2023-03-22"),
                        City = "Brisbane",
                        State = "Australia",
                        Price = 3400,
                        Capacity = 110000,
                        FirstMatch = "Ireland Vs Australia"
                        
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}