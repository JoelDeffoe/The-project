using SimpleWebScaraper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScaraper.Workers
{
    class Scraper
    {
        public List<string> Scarpe(ScrapeCretaria scrapeCretaria)
        {
            List<string> scrapedElement = new List<string>();
            MatchCollection matches = Regex.Matches(scrapeCretaria.Data,scrapeCretaria.Regex,scrapeCretaria.RegexOption);

            foreach(Match match in matches)
            {
                if (!scrapeCretaria.Parts.Any())
                {
                    scrapedElement.Add(match.Groups[0].Value);
                }
                else
                {
                    foreach(var part in scrapeCretaria.Parts)
                    {
                        Match matchPart = Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOption);

                        if (matchPart.Success) scrapedElement.Add(matchPart.Groups[1].Value);
                    }
                }
            }

            return scrapedElement;
        }
    }
}
