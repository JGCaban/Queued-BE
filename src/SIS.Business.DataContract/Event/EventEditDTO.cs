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
        public EventType TypeOfEvent { get; set; }
        public string Information { get; set; }
        public string Location { get; set; }
        public string ExpectedWait { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
