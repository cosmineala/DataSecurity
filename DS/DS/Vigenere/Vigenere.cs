using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using DS.Dictionary;
using DS.FileManager;

namespace DS.Vigenere
{
    public class Vigenere
    {
        public class Print
        {
            // Clasic
            public static void Encrypt(string message, string key) =>
                Console.WriteLine(Vigenere.Encrypt(message, key));
            public static void Decrypt(string message, string key) =>
                Console.WriteLine(Vigenere.Decrypt(message, key));
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
            // ~ Clasic

            // Auto key
            public static void AutoEncrypt( string message, string key) =>
                Console.WriteLine(Vigenere.AutoEncrypt(message, key));
            public static void AutoDecrypt(string message, string key) =>
                Console.WriteLine(Vigenere.AutoDecrypt(message, key));
            // Auto key

            // Beaufort
            public static void BeaufortEncrypt(string message, string key) =>
                Console.WriteLine(Vigenere.BeaufortEncrypt(message, key));
            public static void BeaufortDecrypt(string message, string key) =>
                Console.WriteLine(Vigenere.BeaufortDecrypt(message, key));
            // ~ Beaufort
        }

        public class File
        {
            // Clasic
            public static void Encrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile( input.Name + "--Vigenere--Encrypt.txt", Vigenere.Encrypt(input.Message, input.Key), input.Key);
            }
            public static void Decrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile( input.Name + "--Vigenere--Decrypt.txt", Vigenere.Decrypt(input.Message, input.Key), input.Key);
            }
            // ~ Clasic

            // Auto key
            public static void AutoEncrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile(input.Name + "--Vigenere_Auto--Encrypt.txt", Vigenere.AutoEncrypt(input.Message, input.Key), input.Key);
            }
            public static void AutoDecrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile(input.Name + "--Vigenere_Auto--Decrypt.txt", Vigenere.AutoDecrypt(input.Message, input.Key), input.Key);
            }
            // ~ Auto key

            // Beaufort
            public static void BeaufortEncrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile(input.Name + "--Beaufort--Encrypt.txt", Vigenere.BeaufortEncrypt(input.Message, input.Key), input.Key);
            }
            public static void BeaufortDecrypt(string filename)
            {
                var input = new CipherFile(filename);
                new CipherFile(input.Name + "--Beaufort--Decrypt.txt", Vigenere.BeaufortDecrypt(input.Message, input.Key), input.Key);
            }
            // ~ Beaufort

        }

        // Clasic
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
                    var part = LetterConvertor.ToNumber(message[i]) - LetterConvertor.ToNumber(key[(i - j) % key.Length]);
                    output += ToCyclicAlphabet(part);
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
            //foreach( var key in keys)
            object lockObkect = new object();
            Parallel.ForEach(keys, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, (key) =>
            {
                var variant = Decrypt(message, key);
                Container container = new Container() { message = variant, matches = WordsAnalyzer.GetMatchesNumber(variant) };
                lock (lockObkect)
                {
                    output.Add( container );
                }
            });
            output.Sort( (x,y)=> y.matches.CompareTo(x.matches ));
            return output;
        }
        // ~ Clasic

        // Auto key
        public static string AutoEncrypt(string message, string key)
        {
            string output = "";
            int j = 0; // nr spatii ( impedica sarire peste caractede din cheie din cauza spatiilor )
            int k = 0; // nr spatii mesaj ( sare peste spatii cand mesajul este folosit ca si cheie )
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    if( i-j < key.Length)
                    {
                        output += LetterConvertor.ToCharUpper((LetterConvertor.ToNumber(message[i]) + LetterConvertor.ToNumber(key[(i - j) % key.Length])) % 26);
                    }
                    else
                    {
                        while (Char.IsLetter(message[i - j + k - key.Length]) == false)
                        {
                            k++;
                        }
                        var letter = LetterConvertor.ToNumber(message[i]);
                        var letterPermutation = LetterConvertor.ToNumber(message[i - j + k - key.Length]);
                        output += LetterConvertor.ToCharUpper(( letter + letterPermutation ) % 26);
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

        public static string AutoDecrypt(string message, string key)
        {
            string output = "";
            int j = 0;
            int k = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    if (i - j < key.Length)
                    {
                        var part = LetterConvertor.ToNumber(message[i]) - LetterConvertor.ToNumber(key[(i - j) % key.Length]);
                        output += ToCyclicAlphabet(part);
                    }
                    else {
                        var keyChar = output[i - j + k - key.Length];
                        while (Char.IsLetter(keyChar) == false)
                        {
                            k++;
                            keyChar = output[i - j + k - key.Length];
                        }
                        var letter = LetterConvertor.ToNumber(message[i]);
                        var letterPermutation = LetterConvertor.ToNumber(output[i - j + k - key.Length]);
                        var part = letter - letterPermutation;
                        output += ToCyclicAlphabet(part);
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
        // ~ Auto Key


        // Beaufort  
        public static string BeaufortEncrypt( string message, string key )
        {
            string output = "";
            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    int partial = LetterConvertor.ToNumber(key[(i - j) % key.Length]) - LetterConvertor.ToNumber(message[i]);

                    if( partial < 0)
                    {
                        output += LetterConvertor.ToCharUpper(partial + 26);
                    }
                    else
                    {
                        output += LetterConvertor.ToCharUpper(partial);
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

        public static string BeaufortDecrypt(string message, string key) =>
            BeaufortEncrypt(message, key);

        // ~ Beaufort


        static private char ToCyclicAlphabet( int part)
        {
            if (part >= 0)
            {
                return LetterConvertor.ToCharUpper(part);
            }
            else
            {
                return LetterConvertor.ToCharUpper(26 + part);
            }
        }

    }
}
