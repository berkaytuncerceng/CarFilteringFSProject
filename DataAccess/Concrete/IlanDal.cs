﻿using Core.DataAccess;
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
    public class IlanDal : DapperRepositoryBase<Ilan>, IIlanDal
    {
        public IlanDal(IDbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
