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

            var i1 = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING";
            var i2 = "OEZEL KRIHD QAFRO ZIMLL GMPBT HEALT ZQNRP GBSPT ZPBAF QFFGQ";

            var k  = "DINTWOFNTHTITTF";

            Vigenere.Print.BeaufortEncrypt(i1, k);
            Vigenere.Print.BeaufortDecrypt(i2, k);

            Vigenere.File.BeaufortEncrypt("DeCriptat_1.txt");
            Vigenere.File.BeaufortDecrypt("DeDecriptat_2.txt");
        }
    }
}
