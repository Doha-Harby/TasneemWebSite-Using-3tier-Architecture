namespace Tass_BLL.ViewModes.Patient
{
    public class CreatePatientVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Hight { get; set; }
        public string? Job { get; set; }
        public string? Diagnosis { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Age { get; private set; }
        public string? Notes { get; private set; }
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
    }
}
