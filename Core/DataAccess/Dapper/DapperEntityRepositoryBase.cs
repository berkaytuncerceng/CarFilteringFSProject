using Core.DataAccess;
using Core.Entities.Abstract;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

public abstract class DapperRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
{
    private IDbConnection _dbConnection;
    protected DapperRepositoryBase(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public List<TEntity> GetAll()
    {
        return _dbConnection.GetAll<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
        return _dbConnection.Get<TEntity>(id);
    }

    public void Add(TEntity entity)
    {
            _dbConnection.Insert(entity);
    }

    public void Update(TEntity entity)
    {
            _dbConnection.Update(entity);
    }

    public void Delete(TEntity entity)
    {
            _dbConnection.Delete(entity);
    }


    public TEntity Get()
    {
        throw new NotImplementedException();
    }
}
