using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class HostConfiguration : IEntityTypeConfiguration<Host>
    {
        public void Configure(EntityTypeBuilder<Host> builder)
        {
            builder.ToTable("TB_HOST");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.HostEmail)
                .HasColumnName("host_email")
                .IsRequired();

            builder.Property(h => h.HostName)
                .HasColumnName("host_name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(h => h.CreatedBy)
                .HasColumnName("created_by");

            builder.Property(h => h.CreatedAt)
                .HasColumnName("created_at")
                .HasDefaultValueSql("UTC_TIMESTAMP");
        }
    }
}
