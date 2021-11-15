using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name ="Oscar";
            personal.lastname ="Avalos";
            personal.age=19;
            personal.phone="7495-8769";
            personal.direccion= "San Miguel, San Miguel"; 
            return View(personal);
        }
    }
}