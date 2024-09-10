using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DoctorNearby.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICabinetRepository, CabinetRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IPatientRepository,PatientRepository>();
            services.AddScoped<ISpecializationRepository, SpecializationRepository>();
        }
    }
}
