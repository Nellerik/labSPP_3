using Microsoft.AspNetCore.Mvc;

namespace labSPP_3.Controllers
{
	public class Lab3Controller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}
	}
}
