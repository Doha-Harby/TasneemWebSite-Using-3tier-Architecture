namespace Tass_BLL.ViewModes.Patient
{
    public class GetAllActivePatientsVM
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public int? Age { get; private set; }
        public decimal? Hight { get; private set; }
        public string? Job { get; private set; }
        public string? Diagnosis { get; private set; }
        public string? Notes { get; private set; }
    }
}
