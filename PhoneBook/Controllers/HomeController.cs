using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneBook.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Search(string SearchedPerson)
        {
            string SearchedTerm = SearchedPerson;

            var person = new List<Person>()
            {
                new Person(){Name="Farshad", Family="Nematpour", PhoneNumber="09167856911", Address ="Iran, Ahvaz, Paadaad"},
                new Person(){Name="Reza", Family="Naseri", PhoneNumber="09367855001",Address = "Iran, Tehran, Jordan"},
                new Person(){Name="Saba", Family="Karimpour", PhoneNumber="09377856001",Address = "Iran, Semnan, Karimi street"},
                new Person(){Name="mahmood", Family="Naseri", PhoneNumber="09017804121",Address = "Germany, Berlin, street 950"},
                new Person(){Name="Taghi", Family="salimi", PhoneNumber="09167855001",Address = "Iran, Ahvaz, Kianpars"}
                
            };


            var result = from p in person
                         where p.Name == SearchedTerm
                         select p;

            //var MyQuery = from s in person
            //            where( s.Name==SearchedTerm || s.Family==SearchedTerm ||
            //            s.PhoneNumber==SearchedTerm || s.Address==SearchedTerm)
            //            select s.PhoneNumber;

            var result2 = person.Where(p => p.Name == SearchedTerm || p.Family == SearchedTerm ||
                                            p.PhoneNumber == SearchedTerm || p.Address == SearchedTerm);

            var res = result;

            foreach (var item in res)
            {
                ViewBag.Name          = item.Name;
                ViewBag.Family        = item.Family;
                ViewBag.PhoneNumber   = item.PhoneNumber;
                ViewBag.Address       = item.Address;
            }

            
            return View();
        }



        [HttpGet]
        public IActionResult GetData(string Name, string Family, string Phone, string Address)
        {
            ViewBag.Name = Name;
            ViewBag.Family = Family;
            ViewBag.Phone = Phone;
            ViewBag.Address = Address;


            return View();
        }

        [HttpPost]
        public IActionResult PostData(string Name, string Family, string Phone, string Address)
        {
            Person person = new Person
            {
                Name = Name,
                Family = Family,
                PhoneNumber = Phone,
                Address = Address
            };
            ViewBag.Person = person;

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
