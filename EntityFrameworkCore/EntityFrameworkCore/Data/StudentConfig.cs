using EntityFrameworkCore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();

            builder.HasData
            (
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Datsunbae",
                    Age = 18,
                    Address = "Binh Tan, HCM"
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Kodoku",
                    Age = 20,
                    Address = "Go Vap, HCM"
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Van Dat",
                    Age = 21,
                    Address = "Go Vap, HCM"
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Justin",
                    Age = 21,
                    Address = "USA"
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Ronaldo",
                    Age = 22,
                    Address = "USA"
                }
            );
        }
    }
}
