using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using DTOs.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
	public class IlanManager : IIlanService
	{
		IIlanDal _ilanDal;

		public IlanManager(IIlanDal ilanDal)
		{
			_ilanDal = ilanDal;
		}

		public IResult Add(Ilan ilan)
		{
			_ilanDal.Add(ilan);
			return new SuccessResult();
		}

		public IResult Delete(Ilan ilan)
		{
			_ilanDal.Delete(ilan);
			return new SuccessResult();
		}
		public IResult Update(Ilan ilan)
		{
			_ilanDal.Update(ilan);
			return new SuccessResult();
		}
		public IDataResult<List<Ilan>> GetAll()
		{
			return new SuccessDataResult<List<Ilan>>(_ilanDal.GetAll());
		}

		public IDataResult<Ilan> GetById(int id)
		{

			return new SuccessDataResult<Ilan>(_ilanDal.GetById(id));
		}

		public IDataResult<List<Ilan>> GetFiltered(IlanForFilterDto filter)
		{
			var ilanlar = _ilanDal.GetAll();

			if (!string.IsNullOrEmpty(filter.Baslik))
			{
				ilanlar = ilanlar.Where(i => i.Baslik.IndexOf(filter.Baslik, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
			}

			if (!string.IsNullOrEmpty(filter.Model))
			{
				ilanlar = ilanlar.Where(i => i.model.Contains(filter.Model)).ToList();//Modele GÖRE
			}

			if (filter.KaynakId.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.KaynakId == filter.KaynakId.Value).ToList();//Kaynağa GÖRE
			}

			if (filter.MinFiyat.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.fiyat >= filter.MinFiyat.Value).ToList();//Minimum Fiyata GÖRE
			}

			if (filter.MaxFiyat.HasValue)
			{
				ilanlar = ilanlar.Where(ilan => ilan.fiyat <= filter.MaxFiyat.Value).ToList();//MAx fiyata GÖRE
			}

			if (filter.MinYil.HasValue)
			{
				ilanlar = ilanlar.Where(i => Convert.ToInt32(i.modelYili) >= filter.MinYil.Value).ToList();//en eski tarihe GÖRE
			}

			if (filter.MaxYil.HasValue)
			{
				ilanlar = ilanlar.Where(i => Convert.ToInt32(i.modelYili) <= filter.MaxYil.Value).ToList();//en yakın tarihe GÖRE
			}

			if (!string.IsNullOrEmpty(filter.Renk))
			{
				ilanlar = ilanlar.Where(i => i.renk.IndexOf(filter.Renk, StringComparison.OrdinalIgnoreCase) >= 0).ToList();//renge GÖRE
			}

			if (filter.MinKm.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.km >= filter.MinKm.Value).ToList();//Min km GÖRE
			}

			if (filter.MaxKm.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.km <= filter.MaxKm.Value).ToList();//Max km GÖRE
			}

			return new SuccessDataResult<List<Ilan>>(ilanlar, "Ilanlar filtrelendi");
		}
		public IDataResult<List<Ilan>> SortASC()
		{
			// Tüm ilanları al
			var ilanlar = _ilanDal.GetAll();

			// Fiyata göre artan sırada sıralama
			ilanlar = ilanlar.OrderBy(i => i.fiyat).ToList();

			// Sonuçları SuccessDataResult ile döndür
			return new SuccessDataResult<List<Ilan>>(ilanlar, "İlanlar artan sırada sıralandı.");
		}



		public IDataResult<List<Ilan>> SortDESC()
		{
			// Tüm ilanları al
			var ilanlar = _ilanDal.GetAll();

			// Fiyata göre artan sırada sıralama
			ilanlar = ilanlar.OrderByDescending(i => i.fiyat).ToList();

			// Sonuçları SuccessDataResult ile döndür
			return new SuccessDataResult<List<Ilan>>(ilanlar, "İlanlar azalan sırada sıralandı.");
		}


	}
}

