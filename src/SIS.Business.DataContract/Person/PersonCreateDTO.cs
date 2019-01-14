using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Person
{
    public class PersonCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
