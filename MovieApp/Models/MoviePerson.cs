using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MoviePerson
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}