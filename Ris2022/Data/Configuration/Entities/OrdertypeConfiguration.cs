using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class OrdertypeConfiguration : IEntityTypeConfiguration<Ordertype>
    {
        public void Configure(EntityTypeBuilder<Ordertype> builder)
        {
            builder.HasData(
                new Ordertype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
