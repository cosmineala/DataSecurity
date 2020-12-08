using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Dictionary
{
    public class CombGen
    {
        public static string AlphabetLow { get; } = "abcdefghijklmnopqrstuvwxyz";
        public static string AlphabetUp { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Alphabet { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";


        public IEnumerable<string> LastGenerate { get; set; }

        public IEnumerable<string> Generate( int lenght, string alphabet)
        {
            var q = alphabet.Select(x => x.ToString());
            for (int i = 0; i < lenght - 1; i++)
            {
                q = q.SelectMany(x => alphabet, (x, y) => x + y);
            }
            this.LastGenerate = q;
            return q;
        }
    }
}
