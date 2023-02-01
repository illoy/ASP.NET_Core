using Microsoft.AspNetCore.Mvc;

namespace Additional_Task.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            return View(result);
        }

        public IActionResult Mul(int x, int y)
        {
            int result = x * y;
            return View(result);
        }

        public IActionResult Div(int x, int y)
        {
            if (y == 0)
            {
                return View(0);
            }
            int result = x / y;
            return View(result);
        }

        public IActionResult Sub(int x, int y)
        {
            int result = x - y;
            return View(result);
        }
    }
}
