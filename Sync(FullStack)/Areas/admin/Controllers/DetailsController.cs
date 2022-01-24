using Microsoft.AspNetCore.Mvc;
using Sync_FullStack_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_FullStack_.Areas.admin.Controllers
{
    public class DetailsController : Controller
    {
        private readonly AppDbContext _context;

        public DetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
