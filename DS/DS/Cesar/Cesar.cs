using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Cesar
{
    public class Cesar
    {
        public static IEnumerable<string> DecryptBruteforce( string message)
        {
            message = message.ToUpper();
            List<string> list = new List<string>();
            for(int i=0; i < 26; i++)
            {
                list.Add(Cesar.Decrypt(message, i));
            }
            return list;
        }
        public static void PrintBruteforce( string message)
        {
            IEnumerable<string> list = DecryptBruteforce(message);
            int i = 0;
            foreach( string element in list)
            {
                Console.WriteLine("+" + i + " >>>" + element );
                i++;
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
                    dencryptedText += Cesar.DecryptLetter(letter, shift);
                }
            }
            return dencryptedText;
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
