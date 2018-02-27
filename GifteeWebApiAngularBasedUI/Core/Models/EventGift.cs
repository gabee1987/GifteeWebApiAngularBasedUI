using System.ComponentModel.DataAnnotations.Schema;

namespace GifteeWebApiAngularBasedUI.Core.Models
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
