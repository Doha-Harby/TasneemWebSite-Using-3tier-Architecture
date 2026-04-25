using System.Diagnostics.Metrics;
using Tass_DAL.Entities;

namespace Tass_BLL.Services.Implementation
{
    public class PatientService(IPatientRepo repository, IMapper mapper) : Service<Patients>(repository), IPatientService
    {
        private readonly IMapper _mapper = mapper;

        public async Task<List<GetAllActivePatientsVM>> GetAllActivePatientsVMAsync()
        {
            var patients = await _repository.GetAllAysnc();
            var activePatients = patients.Where(p => p.IsDeleted == false).ToList();
            return _mapper.Map<List<GetAllActivePatientsVM>>(activePatients);
        }
        public async Task<CreatePatientResponse> CreatePatientAsync(CreatePatientVM model)
        {
            var result = new CreatePatientResponse();

            if (string.IsNullOrWhiteSpace(model.Name))
            {
                result.Success = false;
                result.ErrorMessage = "الاسم مطلوب";
                return result;
            }

            var patient = _mapper.Map<Patients>(model);
            patient.SetCreatedInfo("CurrentUser"); 

            var created = await _repository.CreateAysnc(patient);

            result.Success = true;
            result.CreatedPatient = _mapper.Map<GetAllActivePatientsVM>(created);
            result.PatientId = created.Id;

            return result;
        }
        public async Task<PatientDetailsModifyModeVM> GetPatientDetailsAsync(int id)
        {
            var patient = await repository.GetPatientWithMeasurmentsByIdAsync(id);
          
            var viewModel = new PatientDetailsModifyModeVM
            {
               Patient = _mapper.Map<PatientDetailsVM>(patient),  
               Measurements = _mapper.Map<List<MeasurementVM>>(patient.Measurements ?? []),
               NewMeasurement = new AddMeasurementVM  
               {
                    MeasurementDate = DateTime.Today,
                    PatientId = id
               }
            };

            return viewModel;
        }
        public async Task<PrintPatientDetailsVM> GetPatientDetailsForPrintAsync(int id)
        {
            var patient = await repository.GetPatientWithMeasurmentsByIdAsync(id);

            if (patient == null)
                return null;

            return new PrintPatientDetailsVM
            {
                Patient = _mapper.Map<PatientDetailsVM>(patient),
                Measurements = _mapper.Map<List<MeasurementVM>>(patient.Measurements ?? [])
            };
        }
        public async Task<PatientDetailsVM> UpdatePatientAsync(UpdatePatientVM updatePatientVM)
        {
            var patient = await repository.GetByIdAsync(updatePatientVM.Id) ?? throw new KeyNotFoundException($"Patient with ID {updatePatientVM.Id} not found");
            patient.UpdatePatient(
                updatePatientVM.Name,
                updatePatientVM.Age,
                updatePatientVM.Hight,
                updatePatientVM.Job ?? string.Empty,
                updatePatientVM.Diagnosis ?? string.Empty,
                updatePatientVM.PhoneNumber ?? string.Empty,
                updatePatientVM.Notes ?? string.Empty
            );
            patient.SetUpdatedInfo("CurrentUser");
            var updated = await repository.UpdateAysnc(patient);
            return _mapper.Map<PatientDetailsVM>(updated);
        }
        public async Task<bool> SoftDeletePatientAsync(int id) => await repository.SoftDeleteAysnc(id);
        public async Task<bool> RestoreDeletedPatientAsync(int id) => await repository.RestoreAysnc(id);
        public async Task<List<GetAllDeletedPatientsVM>> GetDeletedPatientsAsync()
        {
            var patients = await repository.GetDeletedAsync();

            return mapper.Map<List<GetAllDeletedPatientsVM>>(patients);
        }
    }

}
