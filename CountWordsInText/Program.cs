using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountWordsInText
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            string txt = "Вот дом, который построил Джек. А это пшеница, которая в темном чулане хранится в доме, который построил Джек. А это веселая птица-синица, которая часто ворует пшеницу, которая в темном чулане хранится в доме, который построил Джек.";
            var charsToRemove = new string[] { ".", ","};
            foreach (var c in charsToRemove)
            {
                txt = txt.Replace(c, string.Empty);
            }
            var words = txt.Split(' ').ToList();
            int countAllWords = 0;
            countAllWords = words.Count;

           

            int countRepeat = 1;
            for (int i = 0;i < words.Count;i++)
            {

                
                try
                {
                    uniqueWords.Add(words[i], countRepeat);
                }
                catch
                {
                    int k = 1;
                    while(true)
                    {
                        if (uniqueWords[words[i]] == countRepeat)
                        {
                            uniqueWords[words[i]] = countRepeat + k;
                            break;
                        }
                        else
                        {
                            uniqueWords[words[i]] += countRepeat;
                            break;
                        }
                    }
                    
                }
                // Console.WriteLine(words[i]);
            }
            int countUniqueWords = 0;
            Console.WriteLine("\tСлово: \t\t\t\tКол-во: ");
            foreach (var k in uniqueWords) {
                countUniqueWords++;
                Console.WriteLine( countUniqueWords  + "." + "\t" + k.Key  + "\t\t\t\t" + k.Value);
            }
           
            Console.WriteLine("Кол-во уникальных слов: " + countUniqueWords + "   Кол-во всех слов: " + countAllWords);


          
          
            
            Console.ReadLine();
        }
    }
}
