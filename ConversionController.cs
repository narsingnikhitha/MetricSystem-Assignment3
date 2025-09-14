using Microsoft.AspNetCore.Mvc;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        // GET: /Conversion/Fahrenheit
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View();
        }

        // POST: /Conversion/Fahrenheit
        [HttpPost]
        public IActionResult Fahrenheit(double? fahrenheit)
        {
            if (!fahrenheit.HasValue)
            {
                ViewBag.Error = "Fahrenheit value is required.";
                return View();
            }

            double celsius = (fahrenheit.Value - 32) * 5 / 9;
            ViewBag.Celsius = celsius;

            return View();
        }
    }
}
