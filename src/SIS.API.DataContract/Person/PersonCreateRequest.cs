using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Person
{
    public class PersonCreateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
