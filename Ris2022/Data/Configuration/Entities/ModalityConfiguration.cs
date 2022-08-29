using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class ModalityConfiguration : IEntityTypeConfiguration<Modality>
    {
        public void Configure(EntityTypeBuilder<Modality> builder)
        {
            builder.HasData(
                new Modality
                {
                    Id = 1,
                    Name = "test",
                    Aetitle = "test",
                    Departmentid =1,
                    Description = "test",
                    Ipaddress = "127.0.0.1",
                    Modalitytypeid = 1,
                    Port = 104
                }
                );
        }
    }
}
