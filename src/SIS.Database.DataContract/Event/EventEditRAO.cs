using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Event
{
    public class EventEditRAO
    {
        public int EventEntityId { get; set; }
        public string EventTitle { get; set; }
        public string Information { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
