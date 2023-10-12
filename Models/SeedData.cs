using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PennyPouch.Data;




namespace PennyPouch.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PennyPouchContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PennyPouchContext>>()))
            {
                // Look for any movies.
                if (context.Pouch.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pouch.AddRange(
                    new Pouch
                    {
                        Name = "Black Leathor Wallet",
                        Color = "Black",
                        Material = "Leather",
                        Style = "Vintage",
                        Pattern = "Soft",
                        Price = 7.99M,
                        Rating = 4
                    },

                    new Pouch
                    {
                        Name = "Black Leathor Wallet",
                        Color = "Black",
                        Material = "Leather",
                        Style = "Vintage",
                        Pattern = "Soft",
                        Price = 7.99M,
                        Rating = 4
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
