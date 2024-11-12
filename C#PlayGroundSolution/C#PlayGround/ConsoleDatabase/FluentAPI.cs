using Microsoft.EntityFrameworkCore;
using ConsoleDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleDatabase
{
    public class FluentAPI : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("AppUser");
            builder.Property(u => u.UserName).HasColumnName("FullName");
        }
    }
}
