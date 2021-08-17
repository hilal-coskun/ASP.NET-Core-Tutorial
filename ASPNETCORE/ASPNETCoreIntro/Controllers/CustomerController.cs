using ASPNETCoreIntro.Entities;
using ASPNETCoreIntro.Models;
using ASPNETCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreIntro.Controllers
{
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index3()
        {
            _logger.Log("");

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, FirstName="Hilal", LastName="Coskun", City="Istanbul"},
                new Customer{Id=2, FirstName="Emine", LastName="Coskun", City="Istanbul"},
                new Customer{Id=3, FirstName="Coskun", LastName="Coskun", City="Istanbul"},
            };

            List<string> shops = new List<string> { "Ankara", "Istanbul", "Izmir" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };

            return View(model);
        }


        [HttpGet]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara", Value="06"},
                    new SelectListItem{Text="Istanbul", Value="34"},
                    new SelectListItem{Text="Izmir", Value="35"},
                }
            });
        }

        [HttpPost]
        public string SaveCustomer(Customer customer)
        {


            return "kaydedildi";
        }
    }
}
