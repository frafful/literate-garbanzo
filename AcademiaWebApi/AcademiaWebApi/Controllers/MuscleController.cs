using AcademiaWebApi.MaintenanceProcessing;
using AcademiaWebApi.Web.Api.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace AcademiaWebApi.Controllers
{
    public class MuscleController : ApiController
    {
        public MuscleController(IMapper mapper, IAddMuscleMaintenanceProcessor addMuscleMaintenanceProcessor)
        {
            _mapper = mapper;
            _addMuscleMaintenanceProcessor = addMuscleMaintenanceProcessor;
        }

        private readonly IMapper _mapper;
        private readonly IAddMuscleMaintenanceProcessor _addMuscleMaintenanceProcessor;


        public Muscle Get(int id)
        {
            var muscleModel = new Data.Entities.Muscle { MuscleId = 1, Name = "Peitoral" };

            return _mapper.Map<Muscle>(muscleModel);
        }

        [HttpPost]
        public IHttpActionResult AddMuscle(HttpRequestMessage request, NewMuscle newMuscle)
        {
            return new MuscleCreatedActionResult(request, _addMuscleMaintenanceProcessor.AddMuscle(newMuscle));
        }
    }
}
