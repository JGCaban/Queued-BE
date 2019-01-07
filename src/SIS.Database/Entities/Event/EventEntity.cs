using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Event
{
    public class EventEntity
    {
        [Key]
        public int EventEntityId { get; set; }

        public string EventTitle { get; set; }
        public string Information { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
