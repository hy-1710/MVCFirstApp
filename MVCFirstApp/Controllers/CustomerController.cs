using MVCFirstApp.Models;
using MVCFirstApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Random()
        {
            var movie = new List<Movie>()
            { new Movie { ID=1 , Name="Up"},
             new Movie { ID=2 , Name="SpiderMan"}
            };

            var customers = new List<Customer>
            {
                new Customer{ Id= 1, Name ="Hitu"},
                new Customer{ Id = 2 ,Name ="Manan"}
            };

            var randomMovieViewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
            };
            return View(randomMovieViewModel);
        }

        public ActionResult details(int id)
        {
            string Name;
            if (id == 1)
            {
                Name = "Hitu";
            }
            else if (id == 2)
            {
                Name = "Manan";
            }
            else
            {
                return HttpNotFound();
            }
            return Content(Name);
        }
    }
}