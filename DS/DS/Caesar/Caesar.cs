using System;
using System.Collections.Generic;
using System.Text;

using DS.Dictionary;

namespace DS.Caesar
{
    public class Caesar
    {
        public class Print
        {
            public static void Bruteforce(string message)
            {
                IEnumerable<string> list = DecryptBruteforce(message);
                int i = 0;
                foreach (string element in list)
                {
                    Console.WriteLine("+" + i + " >>>" + element);
                    i++;
                }
            }
            public static void DecryptCryptanalytic( string message)
            {
                IEnumerable<string> list = Caesar.DecryptCryptanalytic(message);
                foreach( var line in list)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static string Encrypt( string text, int shift)
        {
            string encryptedText = "";
            foreach ( char letter in text)
            {
                if( letter == ' ')
                {
                    encryptedText += ' ';
                }
                else
                {
                    encryptedText += (char)('A' + (((letter - 'A') + shift) % 26));
                } 
            }
            return encryptedText;
        }
        public static string Decrypt(string text, int shift)
        {
            string dencryptedText = "";
            foreach (char letter in text)
            {
                if (letter == ' ')
                {
                    dencryptedText += ' ';
                }
                else
                {
                    dencryptedText += Caesar.DecryptLetter(letter, shift);
                }
            }
            return dencryptedText;
        }

        public static IEnumerable<string> DecryptBruteforce(string message)
        {
            message = message.ToUpper();
            List<string> list = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                list.Add(Caesar.Decrypt(message, i));
            }
            return list;
        }

        public static IEnumerable<string> DecryptCryptanalytic(string message)
        {
            message = message.ToUpper();
            List<string> list = new List<string>();
            LetterCounter counter = new LetterCounter(message);
            counter.sortByAmount();
            var messageFL = counter.GetBest(); // message most frequent letter

            foreach ( var englishFL in LetterCounter.FrequencyList)
            {
                //bestLetter -> freq
                int shift = messageFL - englishFL;
                string output;

                if (shift < 10)
                    output = shift + " ";
                else
                    output = shift.ToString();

                string messageInstance = Decrypt(message, shift);

                int matchees = WordsAnalyzer.GetMatchesNumber( messageInstance );


                output = (char)englishFL + " -> " + messageFL + " | + " + output + " | " + messageInstance + " | No. Macthees:" + matchees ;

                list.Add(output);
            }
            return list;
        }



        public static char DecryptLetter( char letter, int shift)
        {
            int output;
            int letterOrder = letter - 'A';
            int newPossition = letterOrder - shift;
            if(newPossition <0)
            {
                output = 'A' + 26 + newPossition;
            }
            else
            {
                output = 'A' + newPossition;
            }

            return (char)output;
        }

    }
}
