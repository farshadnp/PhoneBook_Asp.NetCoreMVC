using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneBook.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public void ShowName()
        {
           
        }

        public IActionResult Index()
        {
            var people = new List<Person>
            {
                new Person("Farshad","NematPour","09167856911","Iran,Ahvaz,Padaadshahr"),
                new Person("Hamid","KianPoor","09165247852","Iran,tehran,Zafaranie"),
                new Person("Karim","Moosavi","09356001456","Germany,Berlin,Street52"),
                new Person("Sadegh","moghadam","09014578850","UK,London"),
                new Person("Dani","Niknasab","09054001412","Uk,London")
            };

            ViewBag.People = people;


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
