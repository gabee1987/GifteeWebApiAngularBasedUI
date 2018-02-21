using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FromMeToYou.Models
{
    [Table("EventsGifts")]
    public class EventGift
    {
        public int Id { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public int GiftId { get; set; }
        public Gift Gift { get; set; }
    }
}
