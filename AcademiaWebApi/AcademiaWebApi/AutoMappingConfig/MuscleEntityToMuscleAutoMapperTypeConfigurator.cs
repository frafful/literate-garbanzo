using AcademiaWebApi.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcademiaWebApi.AutoMappingConfig
{
    public class MuscleEntityToMuscleAutoMapperTypeConfigurator : AutoMapper.Profile
    {
        protected override void Configure()
        {
            CreateMap<Muscle, Web.Api.Models.Muscle>();
            CreateMap<Web.Api.Models.Muscle, Muscle>();
            CreateMap<Web.Api.Models.NewMuscle, Muscle>();
        }

    }
}