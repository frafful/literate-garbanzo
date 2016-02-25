using AcademiaWebApi.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.MaintenanceProcessing
{
    public interface IAddMuscleMaintenanceProcessor
    {
        Muscle AddMuscle(Muscle muscle);
    }
}
