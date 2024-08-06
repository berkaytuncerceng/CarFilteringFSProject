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

		public IDataResult<List<Ilan>> GetFiltered(IlanForFilterDto filteredIlan)
		{
			var ilanlar = _ilanDal.GetAll();

			if (!string.IsNullOrEmpty(filteredIlan.Baslik))
			{
				ilanlar = ilanlar.Where(i => i.Baslik.IndexOf(filteredIlan.Baslik, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
			}

			if (!string.IsNullOrEmpty(filteredIlan.Model))
			{
				ilanlar = ilanlar.Where(i => i.model.Contains(filteredIlan.Model)).ToList();//Modele GÖRE
			}

			if (filteredIlan.KaynakId.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.KaynakId == filteredIlan.KaynakId.Value).ToList();//Kaynağa GÖRE
			}

			if (filteredIlan.MinFiyat.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.fiyat >= filteredIlan.MinFiyat.Value).ToList();//Minimum Fiyata GÖRE
			}

			if (filteredIlan.MaxFiyat.HasValue)
			{
				ilanlar = ilanlar.Where(ilan => ilan.fiyat <= filteredIlan.MaxFiyat.Value).ToList();//MAx fiyata GÖRE
			}

			if (filteredIlan.MinYil.HasValue)
			{
				ilanlar = ilanlar.Where(i => Convert.ToInt32(i.modelYili) >= filteredIlan.MinYil.Value).ToList();//en eski tarihe GÖRE
			}

			if (filteredIlan.MaxYil.HasValue)
			{
				ilanlar = ilanlar.Where(i => Convert.ToInt32(i.modelYili) <= filteredIlan.MaxYil.Value).ToList();//en yakın tarihe GÖRE
			}

			if (!string.IsNullOrEmpty(filteredIlan.Renk))
			{
				ilanlar = ilanlar.Where(i => i.renk.Contains(filteredIlan.Renk)).ToList();//renge GÖRE
			}

			if (filteredIlan.MinKm.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.km >= filteredIlan.MinKm.Value).ToList();//Min km GÖRE
			}

			if (filteredIlan.MaxKm.HasValue)
			{
				ilanlar = ilanlar.Where(i => i.km <= filteredIlan.MaxKm.Value).ToList();//Max km GÖRE
			}

			return new SuccessDataResult<List<Ilan>>(ilanlar, "Ilanlar filtrelendi");
		}
	}
}

