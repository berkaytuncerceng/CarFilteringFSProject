namespace MVC.Models
{
	public class FilterCriteriaViewModel
	{
		public string? Baslik { get; set; }
		public string? Model { get; set; }
		public KaynakViewModel? Kaynak { get; set; }
		public int MinFiyat { get; set; }
		public int MaxFiyat { get; set; }
		public int MinYil { get; set; }
		public int MaxYil { get; set; }
		public string? Renk { get; set; }
	}
}

