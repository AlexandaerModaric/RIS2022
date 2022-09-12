using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data.Configuration.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<RisAppUser>
    {
        public void Configure(EntityTypeBuilder<RisAppUser> builder)
        {
            builder.HasData(
                           new RisAppUser
                           {
                               Firstname = "RIS",
                               Lastname = "Admin",
                               Email = "RISAdmin@yy.com",
                               Isdoctor = true,
                               PasswordHash = "P@ssw0rd123",
                               UserName = "RISAdmin",
                               EmailConfirmed = true,
                               PhoneNumberConfirmed = true,
                           });
        }
    }
}
