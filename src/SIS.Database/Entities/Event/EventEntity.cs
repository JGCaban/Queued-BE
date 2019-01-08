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

        [Required]
        public string EventTitle { get; set; }

        public string Information { get; set; }

        [Required]
        public int OwnerID { get; set; }

        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
