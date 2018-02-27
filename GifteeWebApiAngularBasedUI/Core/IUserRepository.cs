using GifteeWebApiAngularBasedUI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Core
{
    public interface IUserRepository
    {
        void AddUser(User user);
        Task<User> GetUserAsync(int id, bool includeRelatedGiftees = true);
        Task<IEnumerable<User>> GetAllUsersAsync(bool includeRelatedGiftees = true);
        void RemoveUser(User user);
    }
}
