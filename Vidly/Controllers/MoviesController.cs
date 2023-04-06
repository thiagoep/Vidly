using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "SpongeBob" }
            };

        public List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Thiago" },
                new Customer { Name = "Exequiel" }
            };
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }

        [Route("movies")]
        public ActionResult Movies()
        {

            return View(movies);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            Movie movie = movies.Find(x => x.Id == id);

            if(movie == null)
            {
                return HttpNotFound();
            } 
            else
            {
                return View(movie);
            }
        }

    }
}