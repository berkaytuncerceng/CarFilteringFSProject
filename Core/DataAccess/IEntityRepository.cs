using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using static Dapper.SqlMapper;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        // Add Update Delete Get GetAll

        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public T Get();
        public T GetById(int id);
        public List<T> GetAll();
    }
}
