using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademiaWebApi.Web.Api.Models;
using AutoMapper;
using AcademiaWebApi.Data.Repositories;
using AcademiaWebApi.Data;

namespace AcademiaWebApi.MaintenanceProcessing
{
    public class AddMuscleMaintenanceProcessor : IAddMuscleMaintenanceProcessor
    {
        public AddMuscleMaintenanceProcessor(IMapper mapper, IUnitOfWork unityOfWork, IMuscleRepository muscleRepository)
        {
            _mapper = mapper;
            _unityOfWork = unityOfWork;
            _muscleRepository = muscleRepository;
        }

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unityOfWork;
        private readonly IMuscleRepository _muscleRepository;

        public Muscle AddMuscle(NewMuscle newMuscle)
        {
            var muscleEntity = _mapper.Map<Data.Entities.Muscle>(newMuscle);

            _muscleRepository.Add(muscleEntity);
            _unityOfWork.Save();

            var muscle = _mapper.Map<Muscle>(muscleEntity);

            return muscle;
        }
    }
}