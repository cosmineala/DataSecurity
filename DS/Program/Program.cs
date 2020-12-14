using System;

using DS.Caesar;
using DS.Playfair;
using DS.Dictionary;
using DS.Vigenere;
using System.Diagnostics;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            var i1 = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING";
            var i2 = "SMBIH STSFL WQHVW TEPXW MHDES PMHKD ISBKS QXTWC GXLBM RVIPN";
            var k  = "DINTWOFNTHTITTF";


            Vigenere.Print.AutoEncrypt(i1, k);
            Vigenere.Print.AutoDecrypt(i2, k);
 
        }
    }
}
