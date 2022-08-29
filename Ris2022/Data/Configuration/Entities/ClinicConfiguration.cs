using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasData(
                new Clinic
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
