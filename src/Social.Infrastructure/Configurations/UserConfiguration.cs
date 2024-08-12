using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Social.Domain.Users;

namespace Social.Infrastructure.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Configuration Name Of Table....
        builder.ToTable("Users", "User_Schema_1");

        // Configuration Key.
        builder.HasKey(user => user.Id);

        // Configuration FirstName.
        builder.Property(user => user.FirstName)
               .HasColumnName(nameof(User.FirstName))
               .HasMaxLength(50)
               .IsRequired();

        // Configuration LastName.
        builder.Property(user => user.LastName)
               .HasColumnName(nameof(User.LastName))
               .HasMaxLength(50)
               .IsRequired();

        // Configuration UserName.
        builder.Property(user => user.UserName)
               .HasColumnName(nameof(User.UserName))
               .HasMaxLength(50)
               .IsRequired();

        builder.HasIndex(user => user.UserName).IsUnique();

        // Configuration Email.
        builder.Property(user => user.Email)
               .HasColumnName(nameof(User.Email))
               .HasMaxLength(100)
               .IsRequired();

        builder.HasIndex(user => user.Email).IsUnique();

        // Configuration PasswordHash.
        builder.Property(user => user.PasswordHash)
               .HasColumnName(nameof(User.PasswordHash))
               .HasMaxLength(255)
               .IsRequired();
    }
}
