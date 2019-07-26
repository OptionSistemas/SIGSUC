using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SIGSUC.Domain.Interfaces;
using System.Threading.Tasks;

namespace SIGSUC.Web.Areas.Common.Controllers
{
    public class GridController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GridController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
  
    }
}