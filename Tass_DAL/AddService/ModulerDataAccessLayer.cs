using Microsoft.Extensions.DependencyInjection;
namespace Tass_DAL.AddService
{
    public static class ModulerDataAccessLayer
    {
        public static IServiceCollection AddBusinessInADL(this IServiceCollection services) // this means it is an extention method 
        {
            // ========== Repositories ==========
            services.AddScoped<IMeasurementRepo, MeasurementRepo>();
            services.AddScoped<IPatientRepo, PatientRepo>();

            return services;
        }
    }
}
