using ConsoleApp_DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp_DB.Configurations
{
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Surname).IsRequired();
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.DepartmentNo).IsRequired();
            builder.Property(p => p.Salary).IsRequired();
        }
    }
}
