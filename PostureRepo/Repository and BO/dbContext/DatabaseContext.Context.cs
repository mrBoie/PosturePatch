﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostureRepo.Repository_and_BO.dbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseContextContainer : DbContext
    {
        public DatabaseContextContainer()
            : base("name=DatabaseContextContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ExerciseTemplate> ExerciseTemplateSet { get; set; }
        public virtual DbSet<Exercise> ExerciseSet { get; set; }
        public virtual DbSet<Workout> WorkoutSet { get; set; }
        public virtual DbSet<Client> ClientSet { get; set; }
    }
}
