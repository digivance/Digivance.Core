using Microsoft.EntityFrameworkCore;

namespace Digivance.Core.EntityFramework
{
    /// <summary>
    /// Simple base context definition that we can derrive from to provide IAuditable population functionality.
    /// (E.g. set the dates on IAuditable entities)
    /// </summary>
    public class AuditableContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AuditableContext() : base() { }

        /// <summary>
        /// Standard constructor
        /// </summary>
        /// <param name="options">The context builder options</param>
        public AuditableContext(DbContextOptions<AuditableContext> options) : base(options) { }

        /// <summary>
        /// Custom save changes that calls SetAuditDates before persisting changes
        /// </summary>
        /// <returns>Number of rows affected</returns>
        public override int SaveChanges()
        {
            SetAuditDates();
            return base.SaveChanges();
        }

        /// <summary>
        /// Custom save changes that calls SetAuditDates before persisting changes
        /// </summary>
        /// <returns>Number of rows affected</returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            SetAuditDates();
            return base.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Helper method that will set the correct audit dates (CreatedOn and ModifiedOn)
        /// for any changes we are about to commit to the database
        /// </summary>
        protected void SetAuditDates()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is IAuditable)
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                var entity = entry.Entity as IAuditable;
                if (entry.State == EntityState.Added)
                {
                    entity!.CreatedDate = DateTime.UtcNow;
                }

                entity!.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
