using Tass_BLL.Mapper;

namespace Tass_BLL.AddService
{
    public static class ModulerBusinessLogicLayer
    {
        public static IServiceCollection AddBusinessInBLL(this IServiceCollection services) // this means it is an extention method 
        {
            // ========== Services ==========
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMeasurementService, MeasurementService>();

            // ========== Auto Mapper ==========
            services.AddAutoMapper(m => m.AddProfile(new DomainProfile()));
            return services;
        }
    }
}
