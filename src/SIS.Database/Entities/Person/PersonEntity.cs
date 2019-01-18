using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Person
{
    public class PersonEntity
    {
        [Key]
        public int PersonEntityId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string Phone { get; set; }


        [Required]
        public int OwnerId { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
