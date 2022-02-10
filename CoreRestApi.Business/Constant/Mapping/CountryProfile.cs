using AutoMapper;
using CoreRestApi.Core.CrossCuttingConcern.Dtos;
using CoreRestApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.Business.Constant.Mapping
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<CountryUpdateDto, Country>();
            CreateMap<Country, CountryUpdateDto>();
        }
    }
}
