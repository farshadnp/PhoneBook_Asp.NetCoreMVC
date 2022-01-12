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

            // substring multy value that seperated by ,
            string[] st = SearchedTerm.Split("+");

            var person = new List<Person>()
            {
                new Person(){Name="پارسا", Family="نجابتی", PhoneNumber="09167856911", Address ="ایران - اهواز - کمپولو"},
                new Person(){Name="رضا", Family="ناصری", PhoneNumber="09367855001",Address = "ایران - اهواز - کیانپارس - خیابان 13 شرقی"},
                new Person(){Name="صادق", Family="عالی پور", PhoneNumber="09377856001",Address = "ایران - سمنان- خیابان امت - کوچه 44 - پلاک 12"},
                new Person(){Name="کاظم", Family="ناصری", PhoneNumber="09017804121",Address = "آلمان - شهرک حفاری - ساختمان بیلدینگ"},
                new Person(){Name="تقی", Family="salimi", PhoneNumber="09167855001",Address = "Iran, Ahvaz, Kianpars"},
                new Person(){Name="فرشاد", Family="نعمت پور", PhoneNumber="09167855001",Address = "ایران- اهواز- یوسفی"},
                new Person(){Name="رضا", Family="شوهانی", PhoneNumber="09167855001",Address = "برلین- محله ایرانی ها- خیابان هوشخوله"},
                new Person(){Name="محمود", Family="فرهادی", PhoneNumber="09333785985",Address = "ایران- شیراز- چمران- کوچه شهید رضایی- پلاک 157"},
                new Person(){Name="فرشاد", Family="سعیدی", PhoneNumber="09333986500",Address = "ایران- تهران- اندیشه، فاز4"},
                new Person(){Name="فرشاد", Family="نصیری", PhoneNumber="091680052651",Address = "ایران- کرج- شادی"},
            };



            var resultOfMultyTerm = (from p in person
                                     where 
                                     ( p.Name.Contains(st[0]) && 
                                       p.Family.Contains(st[0]) && 
                                       p.PhoneNumber.Contains(st[0])
                                     )
                                     select p.Name
                                     );

            if (SearchedTerm != null)
            {

            var result2 = (from p in person
                          where p.Name.Contains(SearchedTerm) || p.Family.Contains(SearchedTerm) ||
                          p.PhoneNumber.Contains(SearchedTerm) || p.Address.Contains(SearchedTerm)
                          select p).ToList();
                var res = result2;

                foreach (var item in res)
                {
                    ViewBag.Name = item.Name;
                    ViewBag.Family = item.Family;
                    ViewBag.PhoneNumber = item.PhoneNumber;
                    ViewBag.Address = item.Address;
                }

                return View(res);
            }

            else
            {
                return RedirectToAction("index");
            }
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
