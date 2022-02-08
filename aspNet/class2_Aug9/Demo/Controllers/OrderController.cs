using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    //[Route ("narachka")] //totally overrides the startup.cs default settings
    public class OrderController : Controller
    {

        [Route ("first")]
        public IActionResult Index()
        {
            User person = new User()
            {
                FirstName = "Marija",
                LastName = "Andreevska",
                Address = "Street 66",
                Phone = 0038976831700
            };

            Order order = new Order()
            {
                ID = 1,
                Pizza = "Margherita",
                Price = 350,
                User = person
            };

            ViewData.Add("Title", "Order Home Page");
            ViewData.Add("Order", order);

            return View(order);
        }

        public IActionResult IndexAlternative()
        {
            return View("Alternative");
        }

        public IActionResult Nothing()
        {
            return new EmptyResult();
        }

        public IActionResult Order(int? id)
        {
            if (id.HasValue)
                return View(); //order view
            return RedirectToAction("Index", "Order"); //index view
        }


        [Route("contact")]
        public IActionResult ContactInfo()
        {
            return View();
        }
    }
}
