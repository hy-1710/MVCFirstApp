using MVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstApp.ViewModel
{
    public class RandomMovieViewModel
    {
        public List<Movie> movie { get; set; }

        public List<Customer> customers { get; set; }
    }
}