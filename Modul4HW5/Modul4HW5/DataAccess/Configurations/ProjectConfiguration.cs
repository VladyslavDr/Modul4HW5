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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("Project").IsRequired();
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.BudGet).HasColumnName("BudGet").HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasMaxLength(7).IsRequired();
            builder.HasOne(d => d.Client)
                .WithMany(p => p.Projects)
                .HasForeignKey(d => d.ClientId).IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new Project()
                {
                    Name = "text1",
                    StartedDate = new DateTime(2005, 8, 8, 0, 0, 0),
                    BudGet = 1998.5M,
                    ClientId = 1,
                    ProjectId = 1,
                },
                new Project()
                {
                    Name = "text2",
                    StartedDate = new DateTime(2020, 2, 2, 0, 0, 0),
                    BudGet = 100.12M,
                    ClientId = 2,
                    ProjectId = 2,
                },
                new Project()
                {
                    Name = "text3",
                    StartedDate = new DateTime(2021, 9, 17, 0, 0, 0),
                    BudGet = 2005.8M,
                    ClientId = 3,
                    ProjectId = 3,
                },
                new Project()
                {
                    Name = "text4",
                    StartedDate = new DateTime(2032, 1, 10, 0, 0, 0),
                    BudGet = 15.3M,
                    ClientId = 4,
                    ProjectId = 4,
                },
                new Project()
                {
                    Name = "text5",
                    StartedDate = new DateTime(2005, 8, 8, 0, 0, 0),
                    BudGet = 200.0M,
                    ClientId = 5,
                    ProjectId = 5
                });
        }
    }
}
