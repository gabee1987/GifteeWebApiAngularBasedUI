using GifteeWebApiAngularBasedUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Persistence
{
    public interface IGifteeRepository
    {
        void AddGiftee(Giftee giftee);
        Task<Giftee> GetGifteeAsync(int id, bool includeRelatedUser = false);
        void RemoveGiftee(Giftee giftee);
    }
}
