using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscranbler;

namespace WordUnscrabler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();
        [TestMethod]
        public void MatcheWordeInTheListe()
        {
            string[] word = { "cat", "chair", "more" };
            string[] scrableWord = { "omer" };

            var matcheWordl = _wordMatcher.Match( scrableWord, word);

            Assert.IsTrue(matcheWordl.Count == 1);
            Assert.IsTrue(matcheWordl[0].ScrambleWorld.Equals("omer"));
            Assert.IsTrue(matcheWordl[0].Word.Equals("more"));
        }

        [TestMethod]
        public void MatchesWordesInTheListe()
        {
            string[] word = { "cat", "chair", "more" };
            string[] scrableWord = { "omer", "act" };

            var matcheWordl = _wordMatcher.Match(scrableWord, word);

            Assert.IsTrue(matcheWordl.Count == 2);
            Assert.IsTrue(matcheWordl[0].ScrambleWorld.Equals("omer"));
            Assert.IsTrue(matcheWordl[0].Word.Equals("more"));
            Assert.IsTrue(matcheWordl[1].ScrambleWorld.Equals("act"));
            Assert.IsTrue(matcheWordl[1].Word.Equals("cat"));
        }
    }
}
