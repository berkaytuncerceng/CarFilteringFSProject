using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using DataAccess.Concrete;
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
        public IDataResult<List<Ilan>> GetAll()
        {
            return new SuccessDataResult<List<Ilan>>(_ilanDal.GetAll());
        }

        public IDataResult<Ilan> GetById(int id)
        {
            return new SuccessDataResult<Ilan>(_ilanDal.GetById(id));
        }

        public IResult Update(Ilan ilan)
        {
            _ilanDal.Update(ilan);
            return new SuccessResult();
        }
    }
}
