namespace UniversitySystem.Data.Crawler
{
    using AngleSharp;
    using AngleSharp.Dom;
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UniversityCrawler
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            var document = await context.OpenAsync("http://unichoice.bg/universiteti/");

            var allUniversityUrls = document.QuerySelectorAll("tr > td > a");
            var uniqueUniversityUrls = allUniversityUrls.Select(x => x.GetAttribute("href")).Distinct();

            foreach (var item in uniqueUniversityUrls)
            {
                Console.WriteLine("--------NEW UNIVERSITY--------");
                IDocument universityDoc = await GetUniversityData(context, item);

                //Console.WriteLine(item);
            }

        }

        private static async Task<IDocument> GetUniversityData(IBrowsingContext context, string url)
        {
            var document = await context.OpenAsync($"{url}");

            //get University name 
            var universityName = document.QuerySelector("#uniHead > h2");
            Console.WriteLine(universityName.InnerHtml);

            //get city
            var cityName = document.QuerySelector("#cityGerb");
            Console.WriteLine(cityName.TextContent);

            //get website
            var website = document.QuerySelector("#uniInfo > a");
            Console.WriteLine(website.InnerHtml);
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
