using Infrastructure.EF.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.DatabaseContext
{
    public class AppDbContext : IdentityDbContext<UserEntity,UserRole,int>
    {
        public DbSet<LanguageEntity> Languages { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<ProjectStatusEntity> ProjectStatuses { get; set; }
        public DbSet<TeamRoleEntity> TeamRoles { get; set; }
        public DbSet<StatusEntity> Statuses { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<TechEntity> Technologies { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TeamUserEntity> TeamUsers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "DATA SOURCE=DESKTOP-Q4TE75C;DATABASE=ProjektBACKENDAPI;Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamUserEntity>().HasKey(u => new
            {
                u.UserId,
                u.TeamId,
                u.RoleId
            });

            new Seeder(modelBuilder)
                .SeedRoles()
                .SeedLanguages()
                .SeedTechnologies()
                .SeedStatuses();
        }
    }
}
