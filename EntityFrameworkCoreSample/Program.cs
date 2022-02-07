using EntityFrameworkCoreSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace EntityFrameworkCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = configurationBuilder.Build();

            serviceCollection.AddDbContextPool<BloggingContext>(options => options.UseSqlServer(configuration.GetConnectionString("test")));

            var services = serviceCollection.BuildServiceProvider();

            var instance = ActivatorUtilities.CreateInstance<MyClass>(services);

            instance.RunSample();

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
