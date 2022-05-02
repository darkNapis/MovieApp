using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Person
    {
        //[Key]
        public int PersonId { get; set; }
        //public string Actor { get; set; }
        //public string Producer { get; set; }
        //public string Director { get; set; }
        public virtual List<Role> Roles { get; set; }
        //public virtual Role Role { get; set; }
        //public Person()
        //{
        //    this.Roles = new HashSet<Role>();
        //    this.Movies = new HashSet<Movie>();
        //}

        //public ICollection<Role> Roles { get; set; }
        //public ICollection<Movie> Movies { get; set; }
        //public ICollection<PersonRole> PersonRoles { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}