using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_Training.Models;

namespace Vidly_MVC_Training.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}