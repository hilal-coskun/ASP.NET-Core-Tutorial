using ASPNETCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreIntro.Models
{
    public class SaveCustomerViewModel
    { 
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
