namespace Tass_BLL.ViewModes.Patient
{
    public class PrintPatientDetailsVM
    {
        public PatientDetailsVM? Patient { get; set; }
        public List<MeasurementVM>? Measurements { get; set; } = [];
    }
}
