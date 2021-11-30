using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ShiftApp.Models;
using Microsoft.AspNetCore.Identity;


namespace ShiftApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Posts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Professional>()
            .HasMany(p => p.Patients)
            .WithMany(p => p.Professionals)
            .UsingEntity(j => j.ToTable("ProfessionalsPatients"));

            builder.Entity<ApplicationUser>(entity => entity.ToTable(name: "Users"));
            builder.Entity<IdentityRole>(entiy => entiy.ToTable(name: "Roles"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UsersRoles"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UsersClaims"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UsersLogins"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RolesClaims"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UsersTokens"));
        }

    }
}
