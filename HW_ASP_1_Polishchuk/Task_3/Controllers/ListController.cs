using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task_3.Models;

namespace Task_3.Controllers
{
    public class ListController : Controller
    {
        private readonly OSTextReader _textReader;

        public ListController()
        {
            _textReader = new OSTextReader();
        }
        public IActionResult Info()
        {
            List<OperatingSystem> operatingSystems = _textReader.ReadFromFile();

            return View(operatingSystems);
        }
    }
}
