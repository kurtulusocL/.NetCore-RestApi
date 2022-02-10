using CoreRestApi.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.Core.CrossCuttingConcern.Dtos
{
    public class CountryCreateDto : BaseDto
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
    }
}
