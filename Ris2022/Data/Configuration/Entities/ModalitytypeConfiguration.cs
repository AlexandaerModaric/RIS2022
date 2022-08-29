using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class ModalitytypeConfiguration : IEntityTypeConfiguration<Modalitytype>
    {
        public void Configure(EntityTypeBuilder<Modalitytype> builder)
        {
            builder.HasData(
                new Modalitytype
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
