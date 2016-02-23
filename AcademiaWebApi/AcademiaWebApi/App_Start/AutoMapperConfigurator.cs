using AcademiaWebApi.Common.Mappers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademiaWebApi.App_Start
{
    public class AutoMapperConfigurator
    {
        public void Configure(IEnumerable<IAutoMapperTypeConfigurator> autoMapperTypeConfigurations)
        {
            autoMapperTypeConfigurations.ToList().ForEach(a => a.Configure());
            Mapper.AssertConfigurationIsValid();
        }
    }
}