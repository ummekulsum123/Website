using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Domain.Entities;

namespace Website.Infrastructure.EntityConfigurations
{
    /// <summary>
    /// Представляет конфигурации для сущности <see cref="Student"/>.
    /// </summary>
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.Property(k => k.Birthdate).IsRequired();
        }
    }
}
