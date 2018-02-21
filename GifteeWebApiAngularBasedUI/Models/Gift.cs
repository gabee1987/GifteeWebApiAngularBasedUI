using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FromMeToYou.Models
{
    [Table("Gifts")]
    public class Gift
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string StoreLink { get; set; }

        public ICollection<EventGift> EventGifts { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
    }
}
