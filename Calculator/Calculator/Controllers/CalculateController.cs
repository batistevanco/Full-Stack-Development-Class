using Calculator.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalcVM calcVM)
        {
            return View(calcVM);
        }
    }
}
