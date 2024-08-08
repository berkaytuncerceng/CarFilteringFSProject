using Core.Utilities.Results.Abstract;
using DTOs.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IIlanService
	{
		public IResult Add(Ilan entity);
		public IResult Update(Ilan entity);
		public IResult Delete(Ilan entity);
		public IDataResult<Ilan> GetById(int id);
		public IDataResult<List<Ilan>> GetAll();
		IDataResult<List<Ilan>> GetFiltered(IlanForFilterDto ilan);
		public IDataResult<List<Ilan>> SortASC();// Filtrelenmişi döndürmüyor düzelt
		public IDataResult<List<Ilan>> SortDESC(); // Filtrelenmişi döndürmüyor düzelt
		public IDataResult<IlanForCreateDto> GetIlanDetails(int Id);

	}
}
