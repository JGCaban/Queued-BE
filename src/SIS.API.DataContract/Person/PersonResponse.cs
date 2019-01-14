using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Person
{
    public class PersonResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
