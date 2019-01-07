using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Event
{
    public class EventCreateDTO
    {
        public string EventTitle { get; set; }
        public string Information { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
