using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SIGSUC.Web.Areas.Common.Controllers
{
    [Route("api/common/{controller}")]
    [Area("Common")]
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return Content("área comum");
        }
    }
}