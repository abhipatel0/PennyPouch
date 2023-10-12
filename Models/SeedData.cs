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
                        Price = 19.99M,
                        Rating = 3
                    },

                    new Pouch
                    {
                        Name = "Minimalist Wallet",
                        Color = "Blue Ribbon",
                        Material = "Leather",
                        Style = "Minimalist",
                        Pattern = "Solid",
                        Price = 14.99M,
                        Rating = 4
                    },

                    new Pouch
                    {
                        Name = "Minimalist Metal Wallet",
                        Color = "Grey",
                        Material = "Aluminum",
                        Style = "Minimalist",
                        Pattern = "Solid",
                        Price = 21.99M,
                        Rating = 5
                    },

                    new Pouch
                    {
                        Name = "Casual Wallet for Men",
                        Color = "Black",
                        Material = "Leather",
                        Style = "Casual",
                        Pattern = "Floral",
                        Price = 24.99M,
                        Rating = 4
                    },

                    new Pouch
                    {
                        Name = "RFID Wallets",
                        Color = "Brown",
                        Material = "Leather",
                        Style = "Retro",
                        Pattern = "Animal Print",
                        Price = 34.99M,
                        Rating = 4
                    },

                     new Pouch
                     {
                         Name = "Treviso Mens Wallets",
                         Color = "Navy",
                         Material = "Leather",
                         Style = "Classic",
                         Pattern = "Solid",
                         Price = 54.99M,
                         Rating = 5
                     },

                     new Pouch
                     {
                         Name = "Ingram Magnetic Multicard",
                         Color = "Brown",
                         Material = "Leather",
                         Style = " Magnetic Card Case",
                         Pattern = "Slim",
                         Price = 75.00M,
                         Rating = 5
                     },

                     new Pouch
                     {
                         Name = "Quinn Money Clip Bifold",
                         Color = "Brown",
                         Material = "Leather",
                         Style = "Classic",
                         Pattern = "Floral",
                         Price = 16.99M,
                         Rating = 3
                     },

                     new Pouch
                     {
                         Name = "Hide & Seek Wallet",
                         Color = "Caramel",
                         Material = "Leather",
                         Style = "slip pockets",
                         Pattern = "Soft",
                         Price = 39.99M,
                         Rating = 2
                     },

                     new Pouch
                     {
                         Name = "Slim RFID Wallet",
                         Color = "Matte Carbon Fiber",
                         Material = "Carbon Fibre",
                         Style = "Minimalist",
                         Pattern = "Solid",
                         Price = 69.99M,
                         Rating = 5
                     }



                );
                context.SaveChanges();
            }
        }
    }
}
