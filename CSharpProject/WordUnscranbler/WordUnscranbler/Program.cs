using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordUnscranbler
{
    class Program
    {

        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();


        static void Main(string[] args)
        {
            try
            {
                bool continuWordUnscramble = true;

                do
                {
                    Console.WriteLine(Contants.OptionOnHowToEnert);
                    var option = Console.ReadLine() ?? string.Empty;

                    switch (option.ToUpper())
                    {
                        case Contants.File:
                            Console.Write(Contants.EnterViaFile);
                            ExecutFilleOtion();
                            break;

                        case Contants.Manual:
                            Console.Write(Contants.EnterManualy);
                            ExecutManualOption();
                            break;

                        default:
                            Console.Write(Contants.OptionNotReconise);
                            break;

                    }

                    var continuDessition = string.Empty;
                    do
                    {
                        Console.WriteLine(Contants.OptionOnCotinuingThePrograme);

                        continuDessition = (Console.ReadLine() ?? string.Empty);

                    } while (!continuDessition.Equals(Contants.Yes, StringComparison.OrdinalIgnoreCase) && !continuDessition.Equals(Contants.No, StringComparison.OrdinalIgnoreCase));

                    continuWordUnscramble = continuDessition.Equals(Contants.Yes, StringComparison.OrdinalIgnoreCase);
                }
                while (continuWordUnscramble);

            }
            catch (Exception ex)
            {
                Console.WriteLine(Contants.ErrorProgramTerminated + ex.Message);
            }


        }

        private static void ExecutManualOption()
        {
            var manualImput = Console.ReadLine() ?? string.Empty;
            string[] scrableWorld = manualImput.Split(',');
            DiplayMatcheUnscrableWord(scrableWorld);
        }


        private static void ExecutFilleOtion()
        {
            try
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] scrableWorld = _fileReader.Read(filename);
                DiplayMatcheUnscrableWord(scrableWorld);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Contants.LoadingErrore + ex.Message);
            }


        }

        private static void DiplayMatcheUnscrableWord(string[] scrableWorld)
        {
            string[] wordList = _fileReader.Read(Contants.WordListFileName);

            List<MatcheWord> matcheWords = _wordMatcher.Match(scrableWorld, wordList);


            if (matcheWords.Any())
            {
                foreach (var matcheWord in matcheWords)
                {
                    Console.WriteLine(Contants.MatcheFound, matcheWord.ScrambleWorld, matcheWord.Word);
                }
            }
            else
            {
                Console.WriteLine(Contants.MatcheNoteFound);
            }
        }

    }
}
