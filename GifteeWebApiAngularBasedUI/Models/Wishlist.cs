using GifteeWebApiAngularBasedUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FromMeToYou.Models
{
    [Table("Whislists")]
    public class Wishlist
    {
        public int Id { get; set; }

        public int GifteeId { get; set; }
        public Giftee Giftee { get; set; }

        public int GiftId { get; set; }
        public Gift Gift { get; set; }
    }
}
