using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class EventEditRequest
    {
        public int EventEntityID { get; set; }
        public string EventTitle { get; set; }
        public string Information { get; set; }
    }
}
