using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlanService
    {
        public IResult Add(Ilan entity);
        public IResult Update(Ilan entity);
        public IResult Delete(Ilan entity);
        public IDataResult<Ilan> GetById(int id);
        public IDataResult<List<Ilan>> GetAll();
    }
}
