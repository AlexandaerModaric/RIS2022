using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class MartialstatusConfiguration : IEntityTypeConfiguration<Martialstatus>
    {
        public void Configure(EntityTypeBuilder<Martialstatus> builder)
        {
            builder.HasData(
                new Martialstatus
                {
                    Id = 1,
                    Namear = "اختبار",
                    Nameen = "test"
                }
                );
        }
    }
}
