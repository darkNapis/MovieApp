using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MovieGenre
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}