using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_MVC_Training.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}