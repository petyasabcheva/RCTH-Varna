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
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
