using System.ComponentModel.DataAnnotations.Schema;

namespace GifteeWebApiAngularBasedUI.Core.Models
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
