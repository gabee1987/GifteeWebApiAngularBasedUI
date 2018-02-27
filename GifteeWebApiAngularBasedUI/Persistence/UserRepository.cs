using Microsoft.EntityFrameworkCore;
using GifteeWebApiAngularBasedUI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GifteeWebApiAngularBasedUI.Models;

namespace GifteeWebApiAngularBasedUI.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly GifteeDbContext context;

        public UserRepository(GifteeDbContext context)
        {
            this.context = context;
        }

        public void AddUser(User user)
        {
            context.Add(user);
        }

        public async Task<User> GetUserAsync(int id, bool includeRelatedGiftees = true)
        {
            if (!includeRelatedGiftees)
            {
                return await context.Users.FindAsync(id);
            }

            return await context.Users.Include(u => u.Giftees).SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool includeRelatedGiftees = true)
        {
            if (!includeRelatedGiftees)
            {
                return await context.Users.ToListAsync();
            }

            return await context.Users.Include(u => u.Giftees).ToListAsync();
        }

        public void RemoveUser(User user)
        {
            context.Remove(user);
        }
    }
}
