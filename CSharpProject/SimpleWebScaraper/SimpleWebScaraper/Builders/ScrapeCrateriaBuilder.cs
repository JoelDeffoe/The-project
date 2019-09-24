using SimpleWebScaraper.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScaraper.Builders
{
    class ScrapeCrateriaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScraperCriteriaPart> _parts;

        public ScrapeCrateriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
            _parts = new List<ScraperCriteriaPart>();
        }

        public ScrapeCrateriaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }

        public ScrapeCrateriaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCrateriaBuilder WithRegexOptions(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }
        public ScrapeCrateriaBuilder WithParts(ScraperCriteriaPart scraperCriteriaPart)
        {
            _parts.Add(scraperCriteriaPart);
            return this;
        }

        public ScrapeCretaria Build()
        {
            ScrapeCretaria scrapeCretaria = new ScrapeCretaria();
            scrapeCretaria.Data = _data;
            scrapeCretaria.Regex = _regex;
            scrapeCretaria.RegexOption = _regexOption;
            scrapeCretaria.Parts = _parts;

            return scrapeCretaria;
        }
    }
}
