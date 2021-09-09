using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW5.DataAccess;
using Modul4HW5.Entities;
using Modul4HW5;

namespace Modul4HW5
{
    public class Starter
    {
        private AppConfigService _appConfig = new AppConfigService();

        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(_appConfig.ConnectionString);
            dbContext.UseLazyLoadingProxies();

            using (var db = new ApplicationContext(dbContext.Options))
            {
                var query1 = db.Employers
                    .Include(x => x.Office)
                    .Include(x => x.EmployeeProjects)
                    .ToList();

                var query2 = db.Employers.Select(t => new
                {
                    Name = t.FirstName + " " + t.LastName,
                    Experience = (DateTime.Now - t.HiredData).TotalDays / 365
                }).ToArray();

                var query3 = db.Clients
                    .Where(x => x.ClientId == 2)
                    .FirstOrDefault();
                query3.FirstName = "Peter";
                query3.LastName = "Peterson";
                db.SaveChanges();

                var newProject = new Project()
                {
                    Name = "Text",
                    BudGet = 199.99M,
                    Client = new Client()
                    {
                        FirstName = "FName",
                        LastName = "LName",
                        DataOfBirth = new DateTime(1999, 1, 23, 0, 0, 0),
                        PhoneNumber = "+380667993685"
                    }
                };

                var newEmploee = new Employee()
                {
                    FirstName = "ali",
                    LastName = "budda",
                    HiredData = DateTime.Now,
                    DataOfBirth = new DateTime(2005, 3, 2, 0, 0, 0),

                    Office = new Office()
                    {
                        Location = "Budapesht",
                        Title = "dsakl",
                    },

                    Title = new Title()
                    {
                        Name = "text"
                    }
                };

                db.Add(newProject);
                db.SaveChanges();

                db.Add(newEmploee);
                db.SaveChanges();

                db.Employers.Remove(db.Employers.FirstOrDefault(x => x.FirstName == "Olha"));
                db.SaveChanges();

                var query6 = db
                .Employers.Select(x => x.Title).ToList()
                .Where(x => !x.Name.Contains("a"))
                .ToList();
            }

            Console.WriteLine("End");
        }
    }
}
