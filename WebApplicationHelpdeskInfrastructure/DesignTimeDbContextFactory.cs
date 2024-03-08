using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationHelpdeskInfrastructure.Database;

namespace WebApplicationHelpdeskInfrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WebApplicationHelpdeskDbContext>
    {
        
        public WebApplicationHelpdeskDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<WebApplicationHelpdeskDbContext>();

            // Używamy autoryzacji SQL Server bezpośrednio w czasie migracji
            builder.UseSqlServer("Server=DESKTOP-JD2U15O\\MSSQL1;Database=WebHelpdeskApi;Integrated Security=True; TrustServerCertificate=true;");

            return new WebApplicationHelpdeskDbContext(builder.Options);
        }
    }
}

