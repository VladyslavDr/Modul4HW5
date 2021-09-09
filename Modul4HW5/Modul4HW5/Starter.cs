using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modul4HW5
{
    public class Starter
    {
        private AppConfigService _appConfig = new AppConfigService();

        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(_appConfig.ConnectionString);
            using (var db = new ApplicationContext(dbContext.Options))
            {
            }

            Console.WriteLine("End");
        }
    }
}
