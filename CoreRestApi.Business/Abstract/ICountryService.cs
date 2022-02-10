using CoreRestApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.Business.Abstract
{
    public interface ICountryService
    {
        List<Country> GetAll();
        Country GetById(int? id);
        void Create(Country entity);
        void Update(Country entity);
        void Delete(Country entity);
    }
}
