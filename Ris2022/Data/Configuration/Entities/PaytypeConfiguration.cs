using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class PaytypeConfiguration : IEntityTypeConfiguration<Paytype>
    {
        public void Configure(EntityTypeBuilder<Paytype> builder)
        {
            builder.HasData(
                new Paytype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
