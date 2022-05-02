using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        //[Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageData { get; set; }
        public string Link { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Person> Persons { get; set; }
        //public Movie()
        //{
        //    this.Genres = new HashSet<Genre>();
        //    this.Persons = new HashSet<Person>();
        //}

        //public ICollection<Genre> Genres { get; set; }
        //public ICollection<Person> Persons { get; set; }
        //public virtual Genre Genre { get; set; }
        //public virtual Person Person { get; set; }
        //public Guid GenreId { get; set; }
        //public Guid PersonId { get; set; }
    }
}