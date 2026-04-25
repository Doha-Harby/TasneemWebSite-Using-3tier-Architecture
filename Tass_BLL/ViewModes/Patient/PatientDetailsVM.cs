namespace Tass_BLL.ViewModes.Patient
{
    public class PatientDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal? Hight { get; set; }
        public string? Job { get; set; }
        public string? Diagnosis { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Notes { get; set; }
    }
}
