using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class ReasonConfiguration : IEntityTypeConfiguration<Reason>
    {
        public void Configure(EntityTypeBuilder<Reason> builder)
        {
            builder.HasData(
                new Reason
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
