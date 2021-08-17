using ASPNETCoreIntro.Entities;
using ASPNETCoreIntro.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreIntro.Controllers
{
    public class SessionDemoController:Controller
    {

        public string Index1()
        {
            Customer customer = new Customer { Id = 1, FirstName = "Engin" };

            //HttpContext.Session.SetString("isim", "Engin");
            HttpContext.Session.SetObject("musteri", customer);
            return "Session oluştu";
        }

        public string Index2()
        {
            //return HttpContext.Session.GetString("isim");
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.FirstName;
        }
    }
}
