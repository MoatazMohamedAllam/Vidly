using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_Training.Models;

namespace Vidly_MVC_Training.ViewModels
{
    public class NewMovieViewModel
    {
        public int? Id { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "Add Movie";
            }
        }

        public NewMovieViewModel()
        {
            Id = 0;
        }

        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Movie = movie;
        }
    }
}