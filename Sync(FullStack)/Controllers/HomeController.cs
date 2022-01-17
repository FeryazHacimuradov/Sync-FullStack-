using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sync_FullStack_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_FullStack_.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
