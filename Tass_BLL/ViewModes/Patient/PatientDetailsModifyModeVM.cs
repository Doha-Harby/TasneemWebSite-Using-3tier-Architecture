namespace Tass_BLL.ViewModes.Patient
{
    public class PatientDetailsModifyModeVM
    {
        public PatientDetailsVM? Patient { get; set; }
        public UpdatePatientVM? UpdateModel { get; set; }
        public List<MeasurementVM>? Measurements { get; set; } = [];
        public AddMeasurementVM? NewMeasurement { get; set; }  
        public bool IsEditMode { get; set; } = false;
    }
}
