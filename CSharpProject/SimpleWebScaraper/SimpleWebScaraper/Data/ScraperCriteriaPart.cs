using System.Text.RegularExpressions;

namespace SimpleWebScaraper.Data
{
    public class ScraperCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }

    }
}