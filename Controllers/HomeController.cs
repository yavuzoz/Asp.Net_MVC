﻿using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC.Controllers
{
	public class HomeController: Controller
	{
		public IActionResult Index() { return View(); }
	}
}
