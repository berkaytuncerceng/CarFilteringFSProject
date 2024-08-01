using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private IIlanService _ilanService;


		public HomeController(ILogger<HomeController> logger, IIlanService ilanService)
		{
			_logger = logger;
			_ilanService = ilanService;
		}

		public string Index()
		{
			var ilan = _ilanService.GetById(3);
			return "year: " + ilan.Data.modelYili;
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
