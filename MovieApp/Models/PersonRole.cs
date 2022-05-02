using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class PersonRole
    {
        public int RoleId { get; set; }
        public int PersonId { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}