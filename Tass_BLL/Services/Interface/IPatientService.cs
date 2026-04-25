namespace Tass_BLL.Services.Interface
{
    public interface IPatientService : IService<Patients>
    {
        Task<List<GetAllActivePatientsVM>> GetAllActivePatientsVMAsync();
        Task<CreatePatientResponse> CreatePatientAsync(CreatePatientVM model);
        Task<PatientDetailsModifyModeVM> GetPatientDetailsAsync(int id);
        Task<PrintPatientDetailsVM> GetPatientDetailsForPrintAsync(int id);
        Task<PatientDetailsVM> UpdatePatientAsync(UpdatePatientVM updatePatientVM);
        Task<bool> SoftDeletePatientAsync(int id);
        Task<bool> RestoreDeletedPatientAsync(int id);
        Task<List<GetAllDeletedPatientsVM>> GetDeletedPatientsAsync();
    }
}
