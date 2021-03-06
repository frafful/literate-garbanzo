﻿using AcademiaWebApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data.Contexts
{
    public class BodyBuildingContext : DbContext, IUnitOfWork
    {
        public BodyBuildingContext() : base("BodyBuildingContext")
        {

        }

        public IDbSet<Muscle> Muscle { get; set; }

        public void Save()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
