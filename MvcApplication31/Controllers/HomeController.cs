using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication31.Models;
using PeopleCars.Data;

namespace MvcApplication31.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new PersonRepository(Properties.Settings.Default.ConStr);
            return View(new IndexViewModel{People = repo.GetPeople()});
        }

        public ActionResult AddCar(int personId)
        {
            var repo = new PersonRepository(Properties.Settings.Default.ConStr);
            return View(new AddCarViewModel {Person = repo.GetById(personId)});
        }

        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            var repo = new CarRepository(Properties.Settings.Default.ConStr);
            repo.AddCar(car);
            return Redirect("/home/index");
        }

    }
}
