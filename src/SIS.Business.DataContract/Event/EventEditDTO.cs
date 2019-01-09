using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Event
{
    public class EventEditDTO
    {
        public int EventEntityId { get; set; }
        public string EventTitle { get; set; }
        public string Information { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
