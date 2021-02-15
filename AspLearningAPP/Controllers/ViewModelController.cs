using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspLearningAPP.Models;
using AspLearningAPP.ViewModel;

namespace AspLearningAPP.Controllers
{
    public class ViewModelController : Controller
    {
        // GET: ViewModel
        public ActionResult GetRandomMovies()
        {
            List<Customer> Customer = new List<Customer>()
            {
                new Customer{ Id=1,Name="Ankit"},
                new Customer{ Id=2,Name="Soni"},
                new Customer{ Id=3,Name="Zensar"},
                new Customer{ Id=4,Name="Intellisource"}
            };
            Movies movies = new Movies() { Id = 1, MovieName = "The Mechanic", ReleaseYear = "2015" };
            RandomMovieViewModel randomMovieViewModel = new RandomMovieViewModel()
            {
                customers = Customer,
                movies = movies
            };
            return View(randomMovieViewModel);
        }
    }
}