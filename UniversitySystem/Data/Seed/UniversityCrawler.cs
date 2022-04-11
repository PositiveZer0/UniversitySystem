namespace UniversitySystem.Data.Seed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AngleSharp;

    using UniversitySystem.Data.Models;

    public class UniversityCrawler
    {
        private ApplicationDbContext db;
        Random random;

        public UniversityCrawler(ApplicationDbContext db)
        {
            this.db = db;
            this.random = new Random();
        }

        public async Task Crawl()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            var document = await context.OpenAsync("http://unichoice.bg/universiteti/");

            var allUniversityUrls = document.QuerySelectorAll("tr > td > a");
            var uniqueUniversityUrls = allUniversityUrls.Select(x => x.GetAttribute("href")).Distinct();

            foreach (var item in uniqueUniversityUrls)
            {
                var university = new University();
                await GetUniversityData(context, item, university);

            }

        }

        private async Task GetUniversityData(IBrowsingContext context, string url, University university)
        {
            var document = await context.OpenAsync($"{url}");

            //get University name 
            var universityName = document.QuerySelector("#uniHead > h2");
            university.Name = universityName.InnerHtml;

            //get city
            var cityName = document.QuerySelector("#cityGerb");
            //innerHtml return src image
            university.City = cityName.TextContent;

            //get website
            var website = document.QuerySelector("#uniInfo > a");
            university.WebUrl = website.InnerHtml;

            //get all specialities
            var specialities = document.QuerySelectorAll(".usBox");
            foreach (var speciality in specialities)
            {
                university.Specialities.Add(new Speciality
                {
                    Name = speciality.Children[1].FirstElementChild.InnerHtml,
                    MinimumScore = Math.Round(this.GetRandomNumber(18, 28), 2),
                });
            }
            db.Universities.Add(university);
            await db.SaveChangesAsync();
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return this.random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
