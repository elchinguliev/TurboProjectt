using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.Entities
{
    public class CarContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CarDB;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasMany(b=>b.Models).WithOne(m=>m.Brand).HasForeignKey(m=>m.BrandId);
            modelBuilder.Entity<User>().HasMany(u=>u.Advertisiments).WithOne(a=>a.User).HasForeignKey(a=>a.UserId);
            modelBuilder.Entity<Model>().HasMany(m=>m.Advertisements).WithOne(a=>a.Model).HasForeignKey(a=>a.ModelId);
        }


    }

   
}
