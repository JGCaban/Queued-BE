using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Person
{
    public class PersonEditRAO
    {
        public int PersonEntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
