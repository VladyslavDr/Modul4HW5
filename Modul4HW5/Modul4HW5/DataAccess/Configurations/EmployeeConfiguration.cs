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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").IsRequired();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.HiredData).HasColumnName("HiredData").HasMaxLength(7).IsRequired();
            builder.Property(p => p.DataOfBirth).HasColumnName("DataOfBirth");
            builder.HasOne(d => d.Office)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Title)
                .WithMany(p => p.Employes)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Karl",
                    LastName = "Demidovich",
                    DataOfBirth = new DateTime(1998, 10, 5, 5, 5, 5),
                    HiredData = new DateTime(2005, 2, 5, 0, 0, 0),
                    OfficeId = 1,
                    TitleId = 1,
                },
                new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "Max",
                    LastName = "Perkov",
                    DataOfBirth = new DateTime(2007, 10, 5, 5, 5, 5),
                    HiredData = new DateTime(2005, 11, 6, 0, 0, 0),
                    OfficeId = 2,
                    TitleId = 3,
                },
                new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Olha",
                    LastName = "Applovna",
                    DataOfBirth = new DateTime(1998, 8, 1, 5, 5, 5),
                    HiredData = new DateTime(2035, 9, 25, 0, 0, 0),
                    OfficeId = 4,
                    TitleId = 5,
                },
                new Employee()
                {
                    EmployeeId = 4,
                    FirstName = "Boria",
                    LastName = "Pirogov",
                    DataOfBirth = new DateTime(1998, 10, 5, 5, 5, 5),
                    HiredData = new DateTime(2021, 7, 15, 0, 0, 0),
                    OfficeId = 5,
                    TitleId = 2,
                },
                new Employee()
                {
                    EmployeeId = 5,
                    FirstName = "Lutik",
                    LastName = "Yatcuk",
                    DataOfBirth = new DateTime(2003, 10, 5, 5, 5, 5),
                    HiredData = new DateTime(2005, 2, 5, 0, 0, 0),
                    OfficeId = 3,
                    TitleId = 1,
                });
        }
    }
}
