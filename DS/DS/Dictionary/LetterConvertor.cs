using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Dictionary
{
    public class LetterConvertor
    {
        public static int ToNumber( char letter)
        {
            if (Char.IsUpper(letter))
            {
                return letter - 'A';
            }
            else if (Char.IsLower(letter))
            {
                return letter - 'a';
            }
            else
            {
                Console.WriteLine("Error::LetterConvertor>>> input not a letter");
                return -1;
            }
                
        }
        public static char ToCharUpper( int letter)
        {
            if (letter >= 0 && letter <= 25)
            {
                return (char)('A' + letter);
            }
            else
            {
                Console.WriteLine("Error::LetterConvertor>>> input not a letter");
                return '\0';
            }
        }
        public static char ToCharLower( int letter)
        {
            if (letter >= 0 && letter <= 25)
            {
                return (char)('a' + letter);
            }
            else
            {
                Console.WriteLine("Error::LetterConvertor>>> input not a letter");
                return '\0';
            }
        }
    }
}
