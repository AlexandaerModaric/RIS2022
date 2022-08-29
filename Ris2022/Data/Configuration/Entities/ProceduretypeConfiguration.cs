using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class ProceduretypeConfiguration : IEntityTypeConfiguration<Proceduretype>
    {
        public void Configure(EntityTypeBuilder<Proceduretype> builder)
        {
            builder.HasData(
                new Proceduretype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
