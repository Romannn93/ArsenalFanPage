using Microsoft.AspNetCore.Mvc;

namespace ArsenalFanPage.Controllers
{
	public class TrophiesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
