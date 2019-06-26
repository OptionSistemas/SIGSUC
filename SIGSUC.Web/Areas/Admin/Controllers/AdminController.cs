using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SIGSUC.Web.Areas.Admin.Controllers
{
    [Route("api/admin/{controller}")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return Content("area admin");
        }
    }
}