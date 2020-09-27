using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Website.Data.Entities;

namespace Website.Data.EntityConfigurations
{
    /// <summary>
    /// Представляет конфигурации для сущности <see cref="StudentEntity"/>.
    /// </summary>
	public class StudentEntityConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            _ = builder.HasKey(t => t.Id);
            _ = builder.Property(k => k.Birthdate).IsRequired();
        }
    }
}