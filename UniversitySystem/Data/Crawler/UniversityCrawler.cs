namespace UniversitySystem.Data.Crawler
{
    using AngleSharp;
    using AngleSharp.Dom;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UniversitySystem.Data.Models;

    public class UniversityCrawler
    {
        static async Task Crawl(string[] args)
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
                Console.WriteLine("--------NEW UNIVERSITY--------");
                IDocument universityDoc = await GetUniversityData(context, item, university);

                //Console.WriteLine(item);
            }

        }

        private static async Task<IDocument> GetUniversityData(IBrowsingContext context, string url, University university)
        {
            var document = await context.OpenAsync($"{url}");

            //get University name 
            var universityName = document.QuerySelector("#uniHead > h2");
            university.Name = universityName.InnerHtml;
            //Console.WriteLine(universityName.InnerHtml);

            //get city
            var cityName = document.QuerySelector("#cityGerb");
            university.City = cityName.InnerHtml;
            //Console.WriteLine(cityName.TextContent);

            //get website
            var website = document.QuerySelector("#uniInfo > a");
            university.WebUrl = website.InnerHtml;
            //Console.WriteLine(website.InnerHtml);
            //get all specialities
            var specialities = document.QuerySelectorAll(".usBox");
            foreach (var speciality in specialities)
            {
                Console.WriteLine(speciality.Children[1].FirstElementChild.InnerHtml);
            }

            return document;
        }
    }
}
