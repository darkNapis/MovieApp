using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Role
    {
        //[Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        //public virtual Person Person { get; set; }

        //public List<PersonRole> PersonRoles { get; set; }
        //public Role()
        //{
        //    this.Persons = new HashSet<Person>();
        //}
        public virtual ICollection<Person> Persons { get; set; }
        //public ICollection<PersonRole> PersonRoles { get; set; }
    }
}