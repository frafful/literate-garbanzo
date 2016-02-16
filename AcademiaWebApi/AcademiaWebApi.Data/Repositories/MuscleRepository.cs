using AcademiaWebApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaWebApi.Data.Contexts;

namespace AcademiaWebApi.Data.Repositories
{
    public class MuscleRepository : GenericRepository<Muscle>, IMuscleRepository
    {
        public MuscleRepository(BodyBuildingContext context) : base(context)
        {
        }
    }
}
