using Company.Domain;
using Company.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Company.Persistence
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntityDomain>();
            var currentTime = DateTime.Now;

            foreach (var entry in entries)
            {
                entry.Entity.LastModifiedDate = currentTime;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = currentTime; 
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        public DbSet<CompanyModel>Companies { get; set; }
    }
}
