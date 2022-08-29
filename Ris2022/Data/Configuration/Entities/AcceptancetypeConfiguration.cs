using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class AcceptancetypeConfiguration : IEntityTypeConfiguration<Acceptancetype>
    {
        public void Configure(EntityTypeBuilder<Acceptancetype> builder)
        {
            builder.HasData(
                new Acceptancetype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
