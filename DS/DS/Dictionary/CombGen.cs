using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Dictionary
{
    public class CombGen
    {
        public static string AlphabetLow { get; } = "abcdefghijklmnopqrstuvwxyz";
        public static string AlphabetUp { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Alphabet { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public Print print;
        public CombGen()
        {
            this.print = new Print(this);
        }

        public class Print
        {
            CombGen combGen;
            public Print( CombGen combGen )
            {
                this.combGen = combGen;
            }

            public void Generate(int lenght, string alphabet)
            {
                foreach( var item in combGen.Generate(lenght, alphabet))
                {
                    Console.Write(item + "\t");
                }
            }
        }
        public IEnumerable<string> LastGenerate { get; set; }

        public IEnumerable<string> Generate( int lenght, string alphabet)
        {
            List<string> output = new List<string>();
            object lockObj = new object();
            Parallel.For(1, lenght+1, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, j => //Environment.ProcessorCount
            {
                var q = alphabet.Select(x => x.ToString());
                for (int i = 0; i < j - 1; i++)
                {
                    q = q.SelectMany(x => alphabet, (x, y) => x + y);
                }
                lock (lockObj)
                {
                    output.AddRange(q.ToList<string>());
                }
            });
            this.LastGenerate = output;
            return output;
        }
    }
}
