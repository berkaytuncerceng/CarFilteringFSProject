using Business.Abstract;
using DTOs.Concrete;
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

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(IlanForFilterDto filter)
		{
			var model = new MVC.Models.HomeViewModels.IndexViewModel();
			var result = _ilanService.GetFiltered(filter);
			if (!result.Success)
				return BadRequest();
			model.Ilanlar = result.Data;
			return View(model);
		}

		public IActionResult List()
		{
			return View();
		}
		public IActionResult Details()
		{
			return View();
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
