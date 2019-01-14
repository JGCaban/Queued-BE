using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class EventEditRequest
    {
        public int EventEntityID { get; set; }
        public string EventTitle { get; set; }
        public EventType TypeOfEvent { get; set; }
        public string Information { get; set; }
        public string Location { get; set; }
        public string StartTime { get; set; }
        public decimal Price { get; set; }
        public bool IsAssigned { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPaid { get; set; }
        public bool IsExpired { get; set; }
    }
}
