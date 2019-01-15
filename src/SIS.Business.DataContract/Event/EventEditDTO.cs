using RedStarter.API.DataContract.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Event
{
    public class EventEditDTO
    {
        public int EventEntityId { get; set; }
        public string EventTitle { get; set; }
        public string TypeOfEvent { get; set; }
        public string Information { get; set; }
        public string Location { get; set; }
        public string StartTime { get; set; }
        public decimal Price { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPaid { get; set; }
        public bool IsExpired { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
