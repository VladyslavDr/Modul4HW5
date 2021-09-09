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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId).HasColumnName("ClientId").IsRequired();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(50).IsRequired();
            builder.Property(p => p.DataOfBirth).HasColumnName("DataOfBirth").IsRequired();
            builder.HasData(
                new Client()
                {
                    ClientId = 1,
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    DataOfBirth = new DateTime(1998, 10, 5, 0, 0, 0),
                    PhoneNumber = "+380669785233"
                },
                new Client()
                {
                    ClientId = 2,
                    FirstName = "Max",
                    LastName = "Lisov",
                    DataOfBirth = new DateTime(1999, 7, 25, 0, 0, 0),
                    PhoneNumber = "+380986399555"
                },
                new Client()
                {
                    ClientId = 3,
                    FirstName = "Den",
                    LastName = "Frolov",
                    DataOfBirth = new DateTime(1988, 3, 11, 0, 0, 0),
                    PhoneNumber = "+380669558636"
                },
                new Client()
                {
                    ClientId = 4,
                    FirstName = "Egor",
                    LastName = "Demchuk",
                    DataOfBirth = new DateTime(1960, 8, 17, 0, 0, 0),
                    PhoneNumber = "+380988884659"
                },
                new Client()
                {
                    ClientId = 5,
                    FirstName = "Vovan",
                    LastName = "Romashov",
                    DataOfBirth = new DateTime(1996, 9, 16, 0, 0, 0),
                    PhoneNumber = "+380998696369"
                });
        }
    }
}
