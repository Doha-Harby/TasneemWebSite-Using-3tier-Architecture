namespace Tass_DAL.Data
{
    public class TasneemContext(DbContextOptions<TasneemContext> options) : DbContext(options)
    {
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Measurements> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}