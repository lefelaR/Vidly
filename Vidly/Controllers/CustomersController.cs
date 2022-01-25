
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
   
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name ="Maria Williams" , Id = 2 },
                new Customer { Name ="Reneiloe Letsolonyane", Id = 3 },
            };

            var customer = new RandomMovieViewModel
            {
                Customer = customers
            };

            return View(customer);
            
        }
        public ActionResult Details(int id)
        {

            List<Customer> customers = new List<Customer>()
            {
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name ="Maria Williams" , Id = 2 },
                new Customer { Name ="Reneiloe Letsolonyane", Id = 3 },
            };

            if(customers.Count >= id)
            {
                var customer = customers[id-1];
                return View(customer);
            }
            else
            {
                return StatusCode(404);
            }

            

           
        }
    }
}
