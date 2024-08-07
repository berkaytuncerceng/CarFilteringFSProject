using Business.Abstract;
using DTOs.Concrete;
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

		public IActionResult Index(IlanForFilterDto filter, string sortOrder = null)
		{
			var model = new MVC.Models.HomeViewModels.IndexViewModel();
			var result = _ilanService.GetFiltered(filter);

			if (!result.Success)
			{
				return BadRequest();
			}

			List<Ilan> sortedIlanlar;

			if (sortOrder == "asc")
			{
				var sortResult = _ilanService.SortASC();
				if (!sortResult.Success)
				{
					return BadRequest();
				}
				sortedIlanlar = sortResult.Data;
			}
			else if (sortOrder == "desc")
			{
				var sortResult = _ilanService.SortDESC();
				if (!sortResult.Success)
				{
					return BadRequest();
				}
				sortedIlanlar = sortResult.Data;
			}
			else
			{
				sortedIlanlar = result.Data;
			}

			model.Ilanlar = sortedIlanlar;
			return View(model);
		}


		public IActionResult List(IlanForFilterDto filter)
		{
			var model = new MVC.Models.HomeViewModels.IndexViewModel();
			var result = _ilanService.GetFiltered(filter);
			if (!result.Success)
				return BadRequest();
			model.Ilanlar = result.Data;
			return View(model);
		}

		public IActionResult Details(int Id)
		{
			var model = new MVC.Models.IlanViewModel();
			var result = _ilanService.GetById(Id);
			if (!result.Success)
				return BadRequest();
			model.Id = result.Data.Id;
			model.KaynakId = result.Data.KaynakId;
			model.IlanNo = result.Data.IlanNo;
			model.Baslik = result.Data.Baslik;
			model.Link = result.Data.Link;
			model.imageUrl_L = result.Data.imageUrl_L;
			model.imageUrl_M = result.Data.imageUrl_M;
			model.imageUrl_S = result.Data.imageUrl_S;
			model.model = result.Data.model;
			model.modelYili = result.Data.modelYili;
			model.km = result.Data.km;
			model.renk = result.Data.renk;
			model.fiyat = result.Data.fiyat;
			model.tarih = result.Data.tarih;
			model.yer = result.Data.yer;
			model.kayitTarihi = result.Data.kayitTarihi;


			return View(model);
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
