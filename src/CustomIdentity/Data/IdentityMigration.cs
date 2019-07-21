using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CustomIdentity.Data {
    public class IdentityMigration : IEntityTypeConfiguration<CustomUserTable> {
        public void Configure (EntityTypeBuilder<CustomUserTable> builder) {
            builder.ToTable ("User");
            builder.HasKey (p => p.Id);

            builder.Property (e => e.FirstName)
                .HasColumnType ("varchar(50)").IsUnicode (false);
        }

    }

    public class RoleMigration : IEntityTypeConfiguration<CustomRoleTable> {
        public void Configure (EntityTypeBuilder<CustomRoleTable> builder) {
            builder.ToTable ("Role");
        }
    }
}