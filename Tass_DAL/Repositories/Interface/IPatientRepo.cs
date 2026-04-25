using Tass_DAL.Entities;

namespace Tass_DAL.Repositories.Interface
{
    public interface IPatientRepo : IRepository<Patients>
    {
        Task<Patients> GetPatientWithMeasurmentsByIdAsync(int id);
        //Task<Measurements> CreateMeasurementAsync(Measurements measurement);
        Task<bool> SoftDeleteAysnc(int id);
        Task<bool> RestoreAysnc(int id);
        Task<IEnumerable<Patients>> GetDeletedAsync();
        
    }
}
