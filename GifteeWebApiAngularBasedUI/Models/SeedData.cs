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
                PopulateUsers(context);
                PopulateGiftees(context);
                context.SaveChanges();
            }
        }

        #region Seed Users Table

        private static void PopulateUsers(GifteeDbContext context)
        {
            // Look for any users.
            if (context.Users.Any())
            {
                //context.Database.ExecuteSqlCommand("DELETE from Users");   // Reset DB entities
                return;
            }
            else
            {
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
            }
            context.SaveChanges();
        }

        #endregion


        #region Seed Giftee Table

        private static void PopulateGiftees(GifteeDbContext context)
        {
            // Look for any giftee.
            if (context.Giftees.Any())
            {
                //context.Database.ExecuteSqlCommand("DELETE from Giftees");   // Reset DB entities
                return;
            }

            else
            {
                var user1 = context.Users.SingleOrDefault(u => u.Id == 12030);
                var user2 = context.Users.SingleOrDefault(u => u.Id == 12031);
                var user3 = context.Users.SingleOrDefault(u => u.Id == 12032);
                var user4 = context.Users.SingleOrDefault(u => u.Id == 12033);

                context.Giftees.AddRange(
                                        new Giftee
                                        {
                                            FirstName = "Virág",
                                            LastName = "Kis",
                                            NickName = "tesó",
                                            Email = "virag.pici@gmail.com",
                                            UserId = 12032,
                                            //User = user3

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Ben",
                                            LastName = "Uncle",
                                            NickName = "riceKing",
                                            Email = "ben.uncle@gmail.com",
                                            UserId = 12030,
                                            //User = user1

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Tony",
                                            LastName = "Stark",
                                            NickName = "IronMan",
                                            Email = "tony.stark@gmail.com",
                                            UserId = 12031,
                                            //User = user2

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Steven",
                                            LastName = "Rogers",
                                            NickName = "captain",
                                            Email = "steven.rogers@gmail.com",
                                            UserId = 12031,
                                            //User = user2

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Bruce",
                                            LastName = "Banner",
                                            NickName = "hulk",
                                            Email = "bruce.banner@gmail.com",
                                            UserId = 12031,
                                            //User = user2

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Steven",
                                            LastName = "Strange",
                                            NickName = "Mr.Dr",
                                            Email = "dr.mr@gmail.com",
                                            UserId = 12033,
                                            //User = user4

                                        },
                                        new Giftee
                                        {
                                            FirstName = "Wanda",
                                            LastName = "Maximoff",
                                            NickName = "witch",
                                            Email = "wanda.witch@gmail.com",
                                            UserId = 12033,
                                            //User = user4

                                        });
            }

            context.SaveChanges();

        }

        #endregion
    }
}
