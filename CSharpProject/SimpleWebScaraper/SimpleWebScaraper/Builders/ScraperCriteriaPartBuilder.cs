using SimpleWebScaraper.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleWebScaraper.Builders
{
    class ScraperCriteriaPartBuilder
    {
        private string _regex;
        private RegexOptions _regexOption;

        public ScraperCriteriaPartBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
        }

        public ScraperCriteriaPartBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScraperCriteriaPartBuilder WithRegexOPtion(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }

        public ScraperCriteriaPart Build()
        {
            ScraperCriteriaPart scraperCriteriaPart = new ScraperCriteriaPart();
            scraperCriteriaPart.Regex = _regex;
            scraperCriteriaPart.RegexOption = _regexOption;
            return scraperCriteriaPart;
        }
    }
}
