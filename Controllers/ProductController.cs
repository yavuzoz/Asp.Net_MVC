using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult List()
		{
			return View();
		}
	}
}
