namespace Tass_BLL.Services.Interface
{
    public interface IMeasurementService :IService<Measurements>
    {
        Task<bool> AddMeasurementAsync(AddMeasurementVM model);
    }
}
