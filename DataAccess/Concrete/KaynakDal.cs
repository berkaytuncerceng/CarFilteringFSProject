using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class KaynakDal : DapperRepositoryBase<Kaynak>, IKaynakDal
    {
        public KaynakDal(IDbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
