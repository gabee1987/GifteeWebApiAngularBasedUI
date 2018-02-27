using GifteeWebApiAngularBasedUI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GifteeWebApiAngularBasedUI.Models;
using Microsoft.EntityFrameworkCore;

namespace GifteeWebApiAngularBasedUI.Persistence
{
    // A collection of Domain objects in memory
    public class GifteeRepository : IGifteeRepository
    {
        private readonly GifteeDbContext context;

        public GifteeRepository(GifteeDbContext context)
        {
            this.context = context;
        }


        public void AddGiftee(Giftee giftee)
        {
            context.Add(giftee);
        }

        public async Task<Giftee> GetGifteeAsync(int id, bool getRelatedUser = false)
        {
            if (!getRelatedUser)
            {
                return await context.Giftees.FindAsync(id);
            }
            
            return await context.Giftees.Include(g => g.User).SingleOrDefaultAsync(g => g.Id == id);

        }

        public void RemoveGiftee(Giftee giftee)
        {
            context.Giftees.Remove(giftee);
        }
    }
}
