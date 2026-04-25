namespace Tass_DAL.Entities
{
    public class Measurements
    {
        public int Id { get; private set; }
        public decimal? Chest { get; private set; }
        public decimal? UpperAbdomen { get; private set; }
        public decimal? LowerAbdomen { get; private set; }
        public decimal? Buttocks { get; private set; }
        public DateTime? MeasurementDate { get; private set; } = DateTime.Now;
        public int? PatientId { get; private set; }
        public decimal? Weight { get; private set; }
        public Patients? Patient { get; private set; }
        public void SetMeasurementDate(DateTime date)
        {
            MeasurementDate = date;
        }
    }
}
