﻿using Core.Entities.Abstract;
using Dapper.Contrib.Extensions;

namespace Entities.Concrete
{
	[Table("ilanlar")]
	public class Ilan : IEntity 
	{
		[Key]
		public int Id { get; set; }
		public int KaynakId { get; set; }
		public string? IlanNo { get; set; }
		public string? Baslik { get; set; }
		public string? Link { get; set; }
		public string? imageUrl_S { get; set; }
		public string? imageUrl_M { get; set; }
		public string? imageUrl_L { get; set; }
		public string? model { get; set; }
		public string? modelYili { get; set; }
		public int km { get; set; }
		public string? renk { get; set; }
		public float fiyat { get; set; }
		public DateTime tarih { get; set; }
		public string? yer { get; set; }
		public DateTime kayitTarihi { get; set; }
	}
}
