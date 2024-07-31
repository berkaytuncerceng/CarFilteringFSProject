using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKaynakService
    {
        public IResult Add(Kaynak entity);
        public IResult Update(Kaynak entity);
        public IResult Delete(Kaynak entity);
        public IDataResult<Kaynak> GetById(int id);
        public IDataResult<List<Kaynak>> GetAll();
    }
}
