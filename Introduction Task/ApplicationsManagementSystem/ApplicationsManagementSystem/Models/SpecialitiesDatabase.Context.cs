﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationsManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpecialitiesDatabaseEntities : DbContext
    {
        public SpecialitiesDatabaseEntities()
            : base("name=SpecialitiesDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<DurationType> DurationTypes { get; set; }
        public virtual DbSet<GroupedSpeciality> GroupedSpecialities { get; set; }
        public virtual DbSet<GroupFriendship> GroupFriendships { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<MinScore> MinScores { get; set; }
        public virtual DbSet<OptionalSubjectsGroup> OptionalSubjectsGroups { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<ProfileSubjectsGroup> ProfileSubjectsGroups { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<SpecialityApplication> SpecialityApplications { get; set; }
        public virtual DbSet<SpecialityCapacity> SpecialityCapacities { get; set; }
        public virtual DbSet<SpecialitySubject> SpecialitySubjects { get; set; }
        public virtual DbSet<SpecialityTestOption> SpecialityTestOptions { get; set; }
        public virtual DbSet<StudyFormType> StudyFormTypes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}