using System;
using System.Linq;

namespace SentenceFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter line");
            string sentence = Console.ReadLine().Trim().ToLower();
            while (sentence.Contains("  ") || sentence.Contains(","))
            {
                sentence = sentence.Replace("  ", " ");
                sentence = sentence.Replace(",", " ");
            }
            string[] arraysentence = sentence.Split(" ");

            string[] arrayfindsentence = searchSentenceArrayMethod();
            int uzunluk = arrayfindsentence.Length;

            if (uzunluk > 1) { searchSentenceArrayMethod(); }



            Console.WriteLine("Find sentence count:" + repeatSentenceMethod(arraysentence, arrayfindsentence));
            Console.ReadLine();
        }





        static string[] searchSentenceArrayMethod()
        {
            Console.WriteLine("please search sentence enter");
            string findsentence = Console.ReadLine().Trim().ToLower();
            while (findsentence.Contains("  ") || findsentence.Contains(","))
            {
                findsentence = findsentence.Replace("  ", " ");
                findsentence = findsentence.Replace(",", " ");
            }
            string[] arraysentencefind = findsentence.Split(" ");
            
            return arraysentencefind;
        }

        static int repeatSentenceMethod(string[] s, string[] t)
        {
            int repeat = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[0])
                {
                    repeat++;
                }



            }
            if (repeat == 0) { Console.WriteLine("bulunmadı"); }
            return repeat;
        }
    }
}