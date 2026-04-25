namespace Tass_BLL.Response
{
    public class CreatePatientResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public GetAllActivePatientsVM? CreatedPatient { get; set; }
        public int PatientId { get; set; }
    }
}
