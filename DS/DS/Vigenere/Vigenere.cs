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



    }
}
