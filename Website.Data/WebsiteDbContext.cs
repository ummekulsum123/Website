using Microsoft.EntityFrameworkCore;
using Website.Data.Entities;

namespace Website.Data
{
    /// <summary>
    /// Представляет контекст для доступа к данным в базе данных.
    /// </summary>
	public class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        /// <summary>
        /// Таблица студентов.
        /// </summary>
        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
