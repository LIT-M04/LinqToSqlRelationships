using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeopleCars.Data;

namespace MvcApplication31.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Person> People { get; set; } 
    }
}