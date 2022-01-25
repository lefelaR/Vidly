 using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers

{
    public class MoviesController: Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
       
        public ActionResult Optional()
        {
            var movie = new Movie() { Name = "Shrek the third" };
            return View(movie);  
        }

        public ActionResult View(int id)
        {
            var movie = new Movie() { Name = "Air Plane 1980" };
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Name = "Thabo",Id = 1 },
                new Customer{Name = "Maja",Id=2}
                
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            ViewBag.movie = movie;
    
            return View(ViewModel);
        }



    }
}
