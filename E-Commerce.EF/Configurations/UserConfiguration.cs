using E_Commerce.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.ToTable("User");
            modelBuilder.HasKey(u => u.Id);
            modelBuilder.Property(u => u.Name).IsRequired();
            modelBuilder.Property(u => u.Username).IsRequired();
            modelBuilder.Property(u => u.Password).IsRequired();
            modelBuilder.Property(u => u._Role).IsRequired();
        }
    }
}
