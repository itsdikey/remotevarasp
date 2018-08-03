using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RemoteVar.Corev2.Models.Application;

namespace RemoteVar.Corev2.Models
{
    public class RemoteVarContext : IdentityDbContext<IdentityUser>
    {
        public RemoteVarContext(DbContextOptions<RemoteVarContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Variable>()
                .HasOne(v => v.Application)
                .WithMany(app => app.Variables)
                .HasForeignKey(v => v.AppId);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Application.Application> Applications { get; set; }
        public DbSet<Variable> Variables { get; set; }
    }
}
