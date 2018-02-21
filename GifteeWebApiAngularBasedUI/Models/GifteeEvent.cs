using GifteeWebApiAngularBasedUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FromMeToYou.Models
{
    [Table("GifteesEvents")]
    public class GifteeEvent
    {
        public int Id { get; set; }

        public int GifteeId { get; set; }
        public Giftee Giftee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
