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
            var i2 = "SMBIH STSFL WQHVW TEPXW MHDES PMHKD ISBKS QXTWC GXLBM RVIPN";
            var k  = "DINTWOFNTHTITTF";


            //Vigenere.Print.AutoEncrypt(i1, k);
            //Vigenere.Print.AutoDecrypt(i2, k);

            //foreach( var file in Directory.GetFiles( FileManager.InputsDirectory ))
            //{
            //    Console.WriteLine("\t" + file);
            //}

            CipherFile cipher = new CipherFile("Test1.txt");
            cipher.Print();

            //CipherFile cipher1 = new CipherFile("Output1.txt");
            //cipher1.Key = "key";
            //cipher1.Message = "message";
            //cipher1.Create();

            CipherFile fileOut = new CipherFile("testOut.txt", "Ana are mere", "Pere");

        }
    }
}
