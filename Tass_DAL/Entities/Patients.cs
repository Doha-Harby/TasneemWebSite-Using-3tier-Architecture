namespace Tass_DAL.Entities
{
    public class Patients
    {
        private Patients() { }
        public Patients(string name, int? age, decimal? hight, string job, string diagnosis, string phoneNumber, string notes)
        {
            Name = name;
            Age = age;
            Hight = hight;
            Job = job;
            Diagnosis = diagnosis;
            PhoneNumber = phoneNumber;
            Notes = notes;
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public decimal? Hight { get; private set; }
        public string? Job { get; private set; }
        public string? Diagnosis { get; private set; }
        public string? PhoneNumber { get; private set; }
        public int? Age { get; private set; }
        public string? Notes { get; private set; }
        public List<Measurements>? Measurements { get; private set; } = [];
        public DateTime? CreatedOn { get; private set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; private set; } = DateTime.Now;
        public DateTime? DeletedOn { get; private set; } = DateTime.Now;
        public string? CreatedBy { get; private set; }
        public string? UpdatedBy { get; private set; }
        public string? DeletedBy { get; private set; }
        public bool IsDeleted { get; private set; } = false;

        public void SetCreatedInfo(string createdBy)
        {
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }

        public void SetUpdatedInfo(string updatedBy)
        {
            UpdatedOn = DateTime.Now;
            UpdatedBy = updatedBy;
        }

        public void SoftDeleted()
        {
            IsDeleted = true;
            DeletedOn = DateTime.Now;
        }
        public void Restore()
        {
            IsDeleted = false;
            DeletedOn = DateTime.Now;
        }

        public void UpdatePatient(string name, int? age, decimal? hight, string job, string diagnosis, string phoneNumber, string notes)
        {
            Name = name;
            Age = age;
            Hight = hight;
            Job = job;
            Diagnosis = diagnosis;
            PhoneNumber = phoneNumber;
            Notes = notes;
        }
    }
}
