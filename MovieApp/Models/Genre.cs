using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Genre
    {
        //[Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        //public Genre()
        //{
        //    this.Movies = new HashSet<Movie>();
        //}
        //public ICollection<Movie> Movies { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        //public List<MovieGenre> MovieGenres { get; set; }
    }
}