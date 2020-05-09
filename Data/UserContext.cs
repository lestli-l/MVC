using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manage_core.Models;

namespace Manage_core.Data
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Personal>().HasOne(x => x.Employee).WithOne(x => x.Personal).HasForeignKey<Personal>(x => x.WorkNumber);
        }
        public DbSet<Manage_core.Models.User> User { get; set; }

        public DbSet<Manage_core.Models.Personal> Personal { get; set; }

        public DbSet<Manage_core.Models.Employee> Employee { get; set; }

    }
}
