using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data.Entities
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Muscle> MainMuscles { get; set; }
        public ICollection<Muscle> OtherMuscles { get; set; }
        public Equipment Equipment { get; set; }
    }
}
