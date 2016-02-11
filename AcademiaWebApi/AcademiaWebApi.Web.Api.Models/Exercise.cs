using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Web.Api.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Muscle> MainMuscles { get; set; }
        public IEnumerable<Muscle> OtherMuscles { get; set; }
        public Equipment Equipment { get; set; }
    }
}
