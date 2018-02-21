using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GifteeWebApiAngularBasedUI.Context;
using GifteeWebApiAngularBasedUI.Models;

namespace FromMeToYou.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GifteeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GifteeDbContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    context.Database.ExecuteSqlCommand("DELETE from Users");   // Reset DB entities
                }
                context.Users.AddRange(
                     new User
                     {
                         Email = "lili@gmail.com",
                         FirstName = "Lili",
                         LastName = "Vad",
                         Password = "1234"
                     },
                     new User
                     {
                         Email = "nano@gmail.com",
                         FirstName = "Nandor",
                         LastName = "Takats",
                         Password = "Nano1"
                     },
                     new User
                     {
                         Email = "tea@gmail.com",
                         FirstName = "Laci",
                         LastName = "Kis",
                         Password = "2345"
                     },
                    new User
                    {
                        Email = "gabee1987@gmail.com",
                        FirstName = "Gabee",
                        LastName = "Koncz",
                        Password = "6655"
                    });

                context.SaveChanges();
            }
        }
    }
}
