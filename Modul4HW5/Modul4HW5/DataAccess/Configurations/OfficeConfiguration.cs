using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW5.Entities;

namespace Modul4HW5.DataAccess.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(p => p.OfficeId);
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").IsRequired();
            builder.Property(p => p.Location).HasColumnName("Location").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Title).HasColumnName("Title").HasMaxLength(100).IsRequired();
            builder.HasData(
                new Office()
                {
                    Location = "London",
                    OfficeId = 1,
                    Title = "nz",
                },
                new Office()
                {
                    Location = "Germany",
                    OfficeId = 2,
                    Title = "nz"
                },
                new Office()
                {
                    Location = "Ukraine",
                    OfficeId = 3,
                    Title = "nz"
                },
                new Office()
                {
                    Location = "Poland",
                    OfficeId = 4,
                    Title = "nz"
                },
                new Office()
                {
                    Location = "Uganda",
                    OfficeId = 5,
                    Title = "nz"
                });
        }
    }
}
