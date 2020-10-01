using Microsoft.EntityFrameworkCore;
using Website.Domain.Entities;
using Website.Infrastructure.EntityConfigurations;

namespace Website.Infrastructure
{
    /// <summary>
    /// Представляет контекст для доступа к данным в базе данных.
    /// </summary>
    internal class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        /// <summary>
        /// Таблица студентов.
        /// </summary>
        public DbSet<Student> Students { get; set; }
        /// <summary>
        /// Таблица вопросов.
        /// </summary>
        public DbSet<Question> Questions { get; set; }
        /// <summary>
        /// Таблица медиаконтента.
        /// </summary>
        public DbSet<MediaContent> MediaContents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}