using E_Commerce.Core;
using E_Commerce.Core.Models;
using E_Commerce.EF.Configuration;
using E_Commerce.EF.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EF
{
    public class AmazonContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public AmazonContext()
        {

        }
        public AmazonContext(DbContextOptions<AmazonContext> options) 
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = AmazonDb; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
        }
    }
}