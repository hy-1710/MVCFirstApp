using Microsoft.Ajax.Utilities;
using MVCFirstApp.Models;
using MVCFirstApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
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
            if(id==1)
            {
                Name = "Up";
            }else if(id == 2)
            {
                Name = "SpiderMan";
            }
            else
            {
                return HttpNotFound();
            }
            return Content(Name);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //public ActionResult Index(int? PageIndex , string sortBy )
        //{
        //    if (!PageIndex.HasValue)
        //        PageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", PageIndex, sortBy));
             
        //}

        //[Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year , int month)
        //{
        //    return Content(year +"/" +month);
        //}


        
    }
}