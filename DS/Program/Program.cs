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
            Caesar.Print.DecryptCryptanalytic("IOYHB ASILK SESSE NDDAE FRONL WUBGY NQNLB RLNCL PKGYN QNLBR LNCBY UKX");
            Caesar.Print.Bruteforce("IOYHB ASILK SESSE NDDAE FRONL WUBGY NQNLB RLNCL PKGYN QNLBR LNCBY UKX");
        }
    }
}


