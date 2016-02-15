using AcademiaWebApi.Web.Api.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace AcademiaWebApi.Controllers
{
    public class MuscleController : ApiController
    {
        // GET: api/Muscle
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Muscle/5
        public Muscle Get(int id)
        {
            return new Muscle { MuscleId = 1, Name = "Peitoral" };
        }

        // POST: api/Muscle
        public void Post([FromBody]string value)
        {
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
