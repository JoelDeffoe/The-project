using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScaraper.Data
{
    class ScrapeCretaria
    {
        public ScrapeCretaria()
        {
            Parts = new List<ScraperCriteriaPart>();
        }

        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        public List<ScraperCriteriaPart> Parts { get; set; }
    }
}
