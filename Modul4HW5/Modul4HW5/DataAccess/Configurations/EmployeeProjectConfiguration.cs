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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).HasColumnName("EmployeeProjectId").IsRequired();
            builder.Property(p => p.Rate).HasColumnName("Rate").HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasMaxLength(7).IsRequired();
            builder.HasOne(d => d.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
            new EmployeeProject()
            {
                EmployeeProjectId = 1,
                ProjectId = 1,
                EmployeeId = 1,
                Rate = 5
            },
            new EmployeeProject()
            {
                EmployeeProjectId = 2,
                ProjectId = 2,
                EmployeeId = 2,
                Rate = 2
            },
            new EmployeeProject()
            {
                EmployeeProjectId = 3,
                ProjectId = 3,
                EmployeeId = 3,
                Rate = 3
            },
            new EmployeeProject()
            {
                EmployeeProjectId = 4,
                ProjectId = 4,
                EmployeeId = 4,
                Rate = 4
            },
            new EmployeeProject()
            {
                EmployeeProjectId = 5,
                ProjectId = 5,
                EmployeeId = 5,
                Rate = 5
            });
        }
    }
}
