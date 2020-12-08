using System;
using System.Collections.Generic;
using System.Text;

using DS.Dictionary;

namespace DS.Vigenere
{
    public class Vigenere
    {
        public class Print
        {
            public static void Encrypt(string message, string key)
            {
                Console.WriteLine(Vigenere.Encrypt(message, key));
            }

            public static void Decrypt(string message, string key)
            {
                Console.WriteLine(Vigenere.Decrypt(message, key));
            }
            public static void DectyptBruteforce(string message, IEnumerable<string> keys, int amount)
            {
                IEnumerable<Container> output = Vigenere.DecryptBruteforce(message, keys);
                int count = 0;
                foreach(var variant in output)
                {
                    Console.WriteLine(variant.matches + " | " + variant.message);
                    if( count++ > amount)
                    {
                        return;
                    }
                }
            }
        }

        public static string Encrypt( string message, string key)
        {
            string output = "" ;
            int j = 0;
            for( int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    output += LetterConvertor.ToCharUpper((LetterConvertor.ToNumber(message[i]) + LetterConvertor.ToNumber(key[(i - j) % key.Length])) % 26);
                }
                else
                {
                    output += message[i];
                    j++;
                }
            }
            return output;
        }

        public static string Decrypt(string message, string key)
        {
            string output = "";
            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    //output += LetterConvertor.ToCharUpper((LetterConvertor.ToNumber(message[i]) + LetterConvertor.ToNumber(key[(i + j) % key.Length])) % 26);
                    var part = LetterConvertor.ToNumber(message[i]) - LetterConvertor.ToNumber(key[(i - j) % key.Length]);
                    if( part >= 0)
                    {
                        output += LetterConvertor.ToCharUpper(part);
                    }
                    else
                    {
                        output += LetterConvertor.ToCharUpper( 26 + part);
                    }
                }
                else
                {
                    output += message[i];
                    j++;
                }
            }
            return output;
        }

        public class Container
        {
            public string message;
            public int matches;
        }

        public static IEnumerable<Container> DecryptBruteforce(string message, IEnumerable<string> keys )
        {
            List<Container> output = new List<Container>();
            foreach( var key in keys)
            {
                var variant = Decrypt(message, key);
                output.Add(new Container() { message = variant, matches = WordsAnalyzer.GetMatchesNumber(variant) });
            }
            output.Sort( (x,y)=> y.matches.CompareTo(x.matches ));
            return output;
        }
        //Parallel.ForEach(WordsAnalyzer.EnglishWords, new ParallelOptions { MaxDegreeOfParallelism = 2 }, (curentWord) =>
        //    {
        //        if(input.Contains(curentWord))
        //        {
        //            matchesStore.Add();
        //        }
        //    });

    }
}
