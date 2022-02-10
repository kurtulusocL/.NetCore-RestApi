using CoreRestApi.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.Entities.Concrete
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
    }
}
