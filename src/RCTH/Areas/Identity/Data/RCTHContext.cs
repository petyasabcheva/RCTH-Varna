using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RCTH.Areas.Identity.Data;

namespace RCTH.Data
{
    public class RCTHContext : IdentityDbContext<RCTHUser>
    {
        public DbSet<RCTHUser> RCTHUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<MedResult> MedResults { get; set; }
        
        public RCTHContext(DbContextOptions<RCTHContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RCTHUser>()
                .HasIndex(u => u.EGN)
                .IsUnique();

            builder.Entity<BloodGroup>().HasData(
                new BloodGroup() {Id = 1, Name = "A+"},
                new BloodGroup() {Id = 2, Name = "B+"},
                new BloodGroup() {Id = 3, Name = "AB+"},
                new BloodGroup() {Id = 4, Name = "0+"},
                new BloodGroup() {Id = 5, Name = "A-"},
                new BloodGroup() {Id = 6, Name = "B-"},
                new BloodGroup() {Id = 7, Name = "AB-"},
                new BloodGroup() {Id = 8, Name = "0-"}
            );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });

            var user = new RCTHUser()
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                EGN = "000000",
                BirthDate = DateTime.Now
            };

            var password = new PasswordHasher<RCTHUser>();
            var hashed = password.HashPassword(user, "secret");
            user.PasswordHash = hashed;

            builder.Entity<RCTHUser>().HasData(user);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
        }
    }
}
