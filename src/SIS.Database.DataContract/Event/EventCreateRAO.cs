using RedStarter.API.DataContract.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Event
{
    public class EventCreateRAO
    {
        public string EventTitle { get; set; }
        public EventType TypeOfEvent { get; set; }
        public string Information { get; set; }
        public string Location { get; set; }
        public string ExpectedWait { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int OwnerID { get; set; }
    }
}
