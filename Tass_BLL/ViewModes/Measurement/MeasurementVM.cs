namespace Tass_BLL.ViewModes.Measurement
{
    public class MeasurementVM
    {
        public int Id { get; set; }
        public decimal? Chest { get; set; }
        public decimal? UpperAbdomen { get; set; }
        public decimal? LowerAbdomen { get; set; }
        public decimal? Buttocks { get; set; }
        public DateTime MeasurementDate { get; set; } = DateTime.Today;
        public decimal? Weight { get; set; }
        public int PatientId { get; set; }
    }
}
