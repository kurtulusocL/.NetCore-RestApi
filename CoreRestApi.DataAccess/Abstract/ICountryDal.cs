using CoreRestApi.Core.DataAccess;
using CoreRestApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.DataAccess.Abstract
{
    public interface ICountryDal : IEntityRepository<Country>
    {
    }
}