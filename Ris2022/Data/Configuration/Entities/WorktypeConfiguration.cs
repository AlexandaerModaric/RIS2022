using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class WorktypeConfiguration : IEntityTypeConfiguration<Worktype>
    {
        public void Configure(EntityTypeBuilder<Worktype> builder)
        {
            builder.HasData(
                new Worktype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
