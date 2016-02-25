using AcademiaWebApi.MaintenanceProcessing;
using AcademiaWebApi.Web.Api.Models;
using AutoMapper;
using System.Collections.Generic;
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


        // GET: api/Muscle
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Muscle/5
        public Muscle Get(int id)
        {
            var muscleModel = new Data.Entities.Muscle { MuscleId = 1, Name = "Peitoral" };

            return _mapper.Map<Muscle>(muscleModel);
        }

        // POST: api/Muscle
        public Muscle Post(Muscle newMuscle)
        {
            return _addMuscleMaintenanceProcessor.AddMuscle(newMuscle);
        }

        // PUT: api/Muscle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Muscle/5
        public void Delete(int id)
        {
        }
    }
}
