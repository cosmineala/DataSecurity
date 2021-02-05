using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Dictionary
{
    public class DLetter
    {
        public static int ToInt( char letter)
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
                Console.WriteLine("Error :: Dictionary/DLetter.cs >>> input not a letter");
                return -1;
            }
                
        }
        public static char ToCharUp( int letter)
        {
            if (letter >= 0 && letter <= 25)
            {
                return (char)('A' + letter);
            }
            else
            {
                Console.WriteLine("Error :: Dictionary/DLetter.cs >>> input not a letter");
                return '\0';
            }
        }
        public static char ToCharLo( int letter)
        {
            if (letter >= 0 && letter <= 25)
            {
                return (char)('a' + letter);
            }
            else
            {
                Console.WriteLine("Error :: Dictionary/DLetter.cs >>> input not a letter");
                return '\0';
            }
        }

    }
}
