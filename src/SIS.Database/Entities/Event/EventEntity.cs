using RedStarter.API.DataContract.Event;
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
        public EventType TypeOfEvent { get; set; }
        [Required]
        public string EventTitle { get; set; }
        public string Information { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string StartTime { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPaid { get; set; }
        public bool IsExpired { get; set; }
        [Required]
        public int OwnerID { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}