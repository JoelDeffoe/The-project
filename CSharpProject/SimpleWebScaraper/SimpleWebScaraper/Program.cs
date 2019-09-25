using SimpleWebScaraper.Builders;
using SimpleWebScaraper.Data;
using SimpleWebScaraper.Workers;
using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace SimpleWebScaraper
{
    class Program
    {
        private const string Method = "search";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pleas enter the city you would like to scape information from ");
                var craiglistCity = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Pleas enter the cragliste categoy you would like to scape information from ");
                var creglistCategory = Console.ReadLine() ?? string.Empty;

                using (WebClient client = new WebClient())
                {
                    string content = client.DownloadString($"http://{craiglistCity.Replace(" ", string.Empty)}.craigslist.org/{Method}/{creglistCategory}");

                    ScrapeCretaria scrapeCretaria = new ScrapeCrateriaBuilder()
                        .WithData(content)
                        .WithRegex(@"<a herf=\""(.*?)\""data-id=\""(.*?)\""class=\""result-title hdrlnk"">(.*?)</a>")
                        .WithRegexOptions(RegexOptions.ExplicitCapture)
                        .WithParts(new ScraperCriteriaPartBuilder()
                            .WithRegex(@">(.*?)</a>")
                            .WithRegexOPtion(RegexOptions.Singleline)
                            .Build())
                        .WithParts(new ScraperCriteriaPartBuilder()
                            .WithRegex(@"href=\""(.*?)\""")
                            .WithRegexOPtion(RegexOptions.Singleline)
                            .Build())
                        .Build();

                    Scraper scraper = new Scraper();
                    var scrapedElement = scraper.Scarpe(scrapeCretaria);

                    if (scrapedElement.Any())
                    {
                        foreach (var scrapedElements in scrapedElement) Console.WriteLine(scrapedElements);
                    }
                    else
                    {
                        Console.WriteLine("ther ret no Matches");
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
