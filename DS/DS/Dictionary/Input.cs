using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Dictionary
{
    public class Input
    {
        public static string String()
        {
            string input = Console.ReadLine();
            
            if( input != "")
            {
                return input;
            }
            else
            {
                return String();
            }
        }
        public static char Char()
        {
            return (char)Console.Read();
        }
    }
}
