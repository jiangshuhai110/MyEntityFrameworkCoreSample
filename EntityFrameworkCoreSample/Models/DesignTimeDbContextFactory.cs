using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntityFrameworkCoreSample.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BloggingContext>
    {
        public BloggingContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = configurationBuilder.Build();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<BloggingContext>();

            dbContextOptionsBuilder.UseSqlServer(configuration.GetConnectionString("test"), x => x.MigrationsHistoryTable("Migrations", "dbo"));

            return new BloggingContext(dbContextOptionsBuilder.Options);
        }
    }
}
