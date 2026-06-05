
using Tass_DAL.Entities;

namespace Tass_DAL.Repositories.Implementation
{
    public class PatientRepo(TasneemContext context) : Repository<Patients>(context), IPatientRepo
    {
        public async Task<Patients> GetPatientWithMeasurmentsByIdAsync(int id)
        {
            var Patient = await context.Patients
                .Include(m => m.Measurements)
                .FirstOrDefaultAsync(p => p.Id == id);
            return Patient ?? throw new KeyNotFoundException($"Patient with id: {id} not found");
        }
        public async Task<bool> SoftDeleteAysnc(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return false;
            entity.SoftDeleted();
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RestoreAysnc(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return false;
            entity.Restore();
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<Patients>> GetDeletedAsync()
        {
            return await context.Patients
                .IgnoreQueryFilters()
                .Where(p => p.IsDeleted)
                .ToListAsync();
        }
       
    }
}
