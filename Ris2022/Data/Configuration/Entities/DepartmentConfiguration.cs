using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
