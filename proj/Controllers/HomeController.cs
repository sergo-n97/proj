using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj.Models;
using proj.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace proj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            HomeDto model = new HomeDto();
            model.Projects = db.Projects.ToList();
            model.Companies = db.Company.ToList();

            return View(model);
        }

      
    }
}
