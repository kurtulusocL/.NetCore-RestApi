using CoreRestApi.Business.Abstract;
using CoreRestApi.DataAccess.Abstract;
using CoreRestApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreRestApi.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        public readonly ICountryDal _countryDal;
        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void Create(Country entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _countryDal.Add(entity);
        }

        public void Delete(Country entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _countryDal.Delete(entity);
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }

        public Country GetById(int? id)
        {
            return _countryDal.Get(i => i.Id == id);
        }

        public void Update(Country entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _countryDal.Update(entity);
        }
    }
}
