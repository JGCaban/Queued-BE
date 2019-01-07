using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public enum EventType { Sporting=1, Amusement, Product, Movie, Restaurant }
    public class EventCreateRequest
    {
        public int EventId { get; set; }
        public int JumperId { get; set; }
        public int PlacerId { get; set; }
        public EventType Type { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public decimal Price { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPaid { get; set; }
        public bool IsExpired { get; set; }
    }
}
