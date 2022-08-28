using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ris2022.Data.Models;

namespace Ris2022.Data
{
    public class RisDBContext:IdentityDbContext<RisAppUser>
    {
        public RisDBContext()
        {
        }

        public RisDBContext(DbContextOptions<RisDBContext> options)
            : base(options)
        {        }
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Acceptancetype> Acceptancetypes { get; set; } = null!;
        public virtual DbSet<Clinic> Clinics { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Martialstatus> Martialstatuses { get; set; } = null!;
        public virtual DbSet<Modality> Modalities { get; set; } = null!;
        public virtual DbSet<Modalitytype> Modalitytypes { get; set; } = null!;
        public virtual DbSet<Nationality> Nationalities { get; set; } = null!;
        public virtual DbSet<Paytype> Paytypes { get; set; } = null!;
        public virtual DbSet<Proceduretype> Proceduretypes { get; set; } = null!;
        public virtual DbSet<Order> orders { get; set; } = null!;
        public virtual DbSet<Reason> Reasons { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Risuser> Risusers { get; set; } = null!;
        public virtual DbSet<Userrole> Userroles { get; set; } = null!;
        public virtual DbSet<Worktype> Worktypes { get; set; } = null!;
        public virtual DbSet<Ordertype> Ordetypes { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseOracle("Data Source=orcl;User Id=risndb;Password=risndb;Validate Connection=true;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Model.SetMaxIdentifierLength(30);
            modelBuilder.ApplyConfiguration(new ApplcationUserEntityConfiguration());

            modelBuilder.Entity<RisAppUser>(entity =>
            {
                entity.ToTable(name: "AppUser");
            });
            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            //Patient[] patsToSeed = new Patient[6];
            //for (int i = 1; i <= 6; i++)
            //{
            //    patsToSeed[i - 1] = new Patient
            //    {
            //        Id = i,
            //        Firstname = $"post {i}",

            //    };
            //}
            //modelBuilder.Entity<Patient>().HasData(patsToSeed);

        }
    }

    internal class ApplcationUserEntityConfiguration : IEntityTypeConfiguration<RisAppUser>
    {
        void IEntityTypeConfiguration<RisAppUser>.Configure(EntityTypeBuilder<RisAppUser> builder)
        {
            builder.Property(nameof(RisAppUser.Firstname)).HasMaxLength(20);

        }
    }
}
