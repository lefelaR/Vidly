using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie   { get; set; }
        public List <Customer> Customer{ get; set; }
    }
}
