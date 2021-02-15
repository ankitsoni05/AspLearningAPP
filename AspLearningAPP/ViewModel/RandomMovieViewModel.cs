using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspLearningAPP.Models;

namespace AspLearningAPP.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movies movies { get; set; }
        public List<Customer> customers { get; set; }
    }
}