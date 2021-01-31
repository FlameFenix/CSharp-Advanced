using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader wordsReader = new StreamReader("../../../words.txt");

            using (wordsReader)
            {
                string currentLine = wordsReader.ReadLine();

                string[] currentWords = currentLine.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();

                StreamReader textReader = new StreamReader("../../../input.txt");

                Dictionary<string, int> counter = new Dictionary<string, int>();

                using (textReader)
                {
                    string currentTextLine = textReader.ReadLine();

                    while (currentTextLine != null)
                    {
                        string[] TextSplittedToWords = currentTextLine.Split(new[] { " ", ", ", "?", ".", ";", ":", "!", "-" }, StringSplitOptions.RemoveEmptyEntries)
                                                                      .ToArray();

                        for (int i = 0; i < TextSplittedToWords.Length; i++)
                        {
                            string currentWordFromText = TextSplittedToWords[i].ToLower();
                            for (int j = 0; j < currentWords.Length; j++)
                            {
                                string currentWord = currentWords[j].ToLower();

                                if (currentWordFromText == currentWord)
                                {
                                    if (!counter.ContainsKey(currentWord))
                                    {
                                        counter.Add(currentWord.ToLower(), 0);
                                    }
                                    counter[currentWord]++;
                                }
                            }
                        }
                        currentTextLine = textReader.ReadLine();
                    }
                }

                StreamWriter writer = new StreamWriter("../../../output.txt");
                using (writer)
                {
                    foreach (var item in counter.OrderByDescending(x => x.Value))
                    {

                        writer.WriteLine($"{item.Key} - {item.Value}");

                    }
                }
            }
        }
    }
}
