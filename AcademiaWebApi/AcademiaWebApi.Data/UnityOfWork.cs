using AcademiaWebApi.Data.Contexts;
using AcademiaWebApi.Data.Entities;
using AcademiaWebApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data
{
    public class UnityOfWork : IUnityOfWork
    {
        private BodyBuildingContext context = null;
        private GenericRepository<Muscle> muscleRepository;

        public GenericRepository<Muscle> MuscleRepository
        {
            get
            {
                if (muscleRepository == null)
                    muscleRepository = new GenericRepository<Muscle>(context);

                return muscleRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
