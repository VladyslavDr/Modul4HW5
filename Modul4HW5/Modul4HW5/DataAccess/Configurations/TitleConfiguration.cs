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
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.TitleId);
            builder.Property(p => p.TitleId).HasColumnName("TitleId").IsRequired();
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.HasData(
                new Title()
                {
                    Name = "name1",
                    TitleId = 1
                },
                new Title()
                {
                    Name = "name2",
                    TitleId = 2
                },
                new Title()
                {
                    Name = "name3",
                    TitleId = 3
                },
                new Title()
                {
                    Name = "name4",
                    TitleId = 4
                },
                new Title()
                {
                    Name = "name5",
                    TitleId = 5
                });
        }
    }
}
