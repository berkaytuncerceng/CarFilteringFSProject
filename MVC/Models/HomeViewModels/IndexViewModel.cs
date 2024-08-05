using Entities.Concrete;

namespace MVC.Models.HomeViewModels
{
	public class IndexViewModel
	{
		public IEnumerable<Ilan>? Ilanlar { get; set; }
		public IEnumerable<Kaynak>? Kaynaklar { get; set; }
	}
}
