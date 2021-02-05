using System;

using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

using DS.Caesar;
using DS.Playfair;
using DS.Dictionary;
using DS.Vigenere;
using DS.FileManager;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //var t1 = "ana are {}:() 928 meresi pere moi   ";
            //t1 = Playfair.ToPlayfairInput(t1);
            //Console.WriteLine(t1);

            var t2 = "Al b}er t";
            //t2 = Playfair.ToPlayfairKeyFull(t2);
            //Console.WriteLine(t2);

            Matrix matrix = new Matrix(5, 5, t2);
        }
    }
}
