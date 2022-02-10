using CoreRestApi.Core.DataAccess.EntityFramework;
using CoreRestApi.DataAccess.Abstract;
using CoreRestApi.DataAccess.Concrete.EntityFramework.Context;
using CoreRestApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.DataAccess.Concrete.EntityFramework
{
    public class CountryDal : EntityRepositoryBase<Country, ApplicationDbContext>, ICountryDal
    {
    }
}
