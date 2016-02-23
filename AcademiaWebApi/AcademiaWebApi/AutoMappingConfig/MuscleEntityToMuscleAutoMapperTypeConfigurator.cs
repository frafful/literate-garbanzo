using AcademiaWebApi.Common.Mappers;
using AcademiaWebApi.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademiaWebApi.AutoMappingConfig
{
    public class MuscleEntityToMuscleAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<Muscle, Web.Api.Models.Muscle>();

            var a = new MapperConfiguration(lalala => lalala.CreateMap<Muscle, Web.Api.Models.Muscle>());

            var mapper = a.CreateMapper();
        }
    }
}