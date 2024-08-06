namespace DTOs.Concrete
{
	public class IlanForFilterDto
	{
		public string? Baslik { get; set; }
		public string? Model { get; set; }
		public int? KaynakId { get; set; }
		public int? MinFiyat { get; set; }
		public int? MaxFiyat { get; set; }
		public int? MinYil { get; set; }
		public int? MaxYil { get; set; }
		public string? Renk { get; set; }
		public DateTime? MinTarih { get; set; }
		public DateTime? MaxTarih { get; set; }
		public int? MinKm { get; set; }
		public int? MaxKm { get; set; }
	}
}
