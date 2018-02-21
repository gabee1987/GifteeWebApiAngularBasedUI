using FromMeToYou.Models;
using GifteeWebApiAngularBasedUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Context
{
    public class GifteeDbContext : DbContext
    {
        public GifteeDbContext(DbContextOptions<GifteeDbContext> options)
            : base(options)
        {
        }

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Giftee> Giftees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Gift> Gifts { get; set; }

        #endregion
    }
}
