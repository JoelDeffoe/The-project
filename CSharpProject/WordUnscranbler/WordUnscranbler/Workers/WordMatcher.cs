using System;
using System.Collections.Generic;

namespace WordUnscranbler
{
    class WordMatcher
    {
        public System.Collections.Generic.List<MatcheWord> Match(string[] scrableWorld, string[] wordList)
        {
            var matchWords = new List<MatcheWord>();

            foreach(var scrableWorlds in scrableWorld)
            {
                foreach(var word in wordList)
                {
                    if (scrableWorlds.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchWords.Add(BildMatcheWord(scrableWorlds, word));
                    }
                    else
                    {
                        var scrambelWorldArry = scrableWorlds.ToCharArray();
                        var wordArry = word.ToCharArray();
                        Array.Sort(scrambelWorldArry);
                        Array.Sort(wordArry);

                        var sortedScrableword = new string(scrambelWorldArry);
                        var sortedword = new string(wordArry);

                        if(sortedScrableword.Equals(sortedword, StringComparison.OrdinalIgnoreCase))
                        {
                            matchWords.Add(BildMatcheWord(scrableWorlds, word));
                        }

                    }
                }
            }

            return matchWords;
        }

        private MatcheWord BildMatcheWord(string scrambelWord, string word)
        {
            MatcheWord matcheWord = new MatcheWord
            {
                ScrambleWorld = scrambelWord,
                Word = word
            };

            return matcheWord;

        }
    }
}