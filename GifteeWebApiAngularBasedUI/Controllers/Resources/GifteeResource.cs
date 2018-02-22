using FromMeToYou.Models;
using GifteeWebApiAngularBasedUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Controllers.Resources
{
    public class GifteeResource
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }

        public ICollection<GifteeEvent> GifteeEvents { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
    }
}
