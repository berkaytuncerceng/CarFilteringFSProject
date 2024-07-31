using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KaynakManager : IKaynakService
    {
        private IKaynakDal _kaynakDal;

        public KaynakManager(IKaynakDal kaynakDal)
        {
            _kaynakDal = kaynakDal;
        }

        public IResult Add(Kaynak kaynak)
        {
            _kaynakDal.Add(kaynak);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Kaynak kaynak)
        {
            _kaynakDal.Delete(kaynak);
            return new SuccessResult("Eklendi");
        }
        public IDataResult<List<Kaynak>> GetAll()
        {
            return new SuccessDataResult<List<Kaynak>>(_kaynakDal.GetAll());
        }

        public IDataResult<Kaynak> GetById(int id)
        {
            return new SuccessDataResult<Kaynak>(_kaynakDal.GetById(id));
        }

        public IResult Update(Kaynak kaynak)
        {
            _kaynakDal.Update(kaynak);
            return new SuccessResult();
        }
    }
}
