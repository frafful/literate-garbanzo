using AcademiaWebApi.Data.Entities;
using AcademiaWebApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
