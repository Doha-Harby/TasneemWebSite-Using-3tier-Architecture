namespace Tass_BLL.Response
{
    public class UpdatePatientResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public GetAllActivePatientsVM? UpdatedPatient { get; set; }
    }
}
