using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreIntro.Entities;
using ASPNETCoreIntro.Models;

namespace ASPNETCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index2(int id)
        {
            return id.ToString();
        }

        
    }
}
 