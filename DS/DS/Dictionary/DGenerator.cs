using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Dictionary
{
    public class DGenerator
    {
        public static string AlphabetLow { get; } = "abcdefghijklmnopqrstuvwxyz";
        public static string AlphabetUp { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string Alphabet { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static IEnumerable<string> GenerateAll(int lenght, string alphabet)
        {
            List<string> output = new List<string>();
            object lockObj = new object();
            Parallel.For(1, lenght + 1, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, j => //Environment.ProcessorCount
            {
                //Console.WriteLine("J = " + j);
                var q = alphabet.Select(x => x.ToString());
                for (int i = 0; i < j - 1; i++)
                {
                    //Console.WriteLine("\tJ = " + j + " I = " + i);
                    q = q.SelectMany(x => alphabet, (x, y) => x + y);
                }
                lock (lockObj)
                {
                    output.AddRange(q.ToList<string>());
                }
            });
            return output;
        }

        public Print print;
        public DGenerator()
        {
            this.print = new Print(this);
        }

        public class Print
        {
            DGenerator combGen;
            public Print( DGenerator combGen )
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
