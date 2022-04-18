namespace UniversitySystem
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using UniversitySystem.Data;
    using UniversitySystem.Data.Seed;

    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            //Create db and add data
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
            //var uniCrawler = new UniversityCrawler(db);
            //uniCrawler.Crawl().GetAwaiter().GetResult();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
