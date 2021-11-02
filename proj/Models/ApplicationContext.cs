using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proj.Models;

namespace proj.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Company> Company { get; set; }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<Programmer> Programmers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Projects)
                .WithOne(s => s.Company)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<Company>()
               .HasMany(c => c.Programmer)
               .WithOne(s => s.Company)
               .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<Programmer>()
               .HasMany(c => c.Projects)
               .WithMany(s => s.Programmer);

            modelBuilder.Entity<Programmer>()
             .HasOne(c => c.Company)
             .WithMany(s => s.Programmer)
             .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
