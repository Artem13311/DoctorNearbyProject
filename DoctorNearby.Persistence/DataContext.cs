using DoctorNearby.Persistence.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace DoctorNearby.Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        public DbSet<DistrictEntity> Districts { get; set; }
        public DbSet<CabinetEntity> Cabinets { get; set; }
        public DbSet<DoctorEntity> Doctors { get; set; }
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<SpecializationEntity> Specializations { get; set; }




    }
}
