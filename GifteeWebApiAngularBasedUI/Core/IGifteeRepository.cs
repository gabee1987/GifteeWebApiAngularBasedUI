using GifteeWebApiAngularBasedUI.Core.Models;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Core
{
    public interface IGifteeRepository
    {
        void AddGiftee(Giftee giftee);
        Task<Giftee> GetGifteeAsync(int id, bool includeRelatedUser = false);
        void RemoveGiftee(Giftee giftee);
    }
}
