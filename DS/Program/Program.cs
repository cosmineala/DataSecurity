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
        
            var i2 = "OCZYD  AAZMZ  IXZWZ  ORZZI  OMTVI  YOMDP  HKCDN  VGDOO  GZPHK  C";// Caesar, + 21 //
            // THEDI  FFERE  NCEBE  TWEEN  TRYAN  DTRIU  MPHIS  ALITT  LEUMP  H
            // THE DIFFERENCE BETWEEN TRY AND TRIUMPH IS A LITTLE UMPH !!!
            // TDBTATIALU
            var k1 = "TDBTATIALU";

            var i1 = "LRVMH  HNAFM  MUBEIT  ATLHW  VSHYT  TNPQS  HBEAG  LNLPR"; // Vigenere, TDBTATIALU //
            // SOUTH  OFAUS  TRALIA  STAND  SROYA  LNEWZ  EALAN  DNAVY
            // SOUTH  OF AUSTRALIA  STANDS ROYAL NEW ZEALAND NAVY !!!
            // ROYAL NEW ZEALAND NAVY
            var k2 = "ROYAL NEW ZEALAND NAVY";

            var i3 = "KXJEY  UREBE  ZWEHE  WRYTU  HEYFS KREHE  GOYFI  WTTTU  OLKSY  CAJPO BOTEI  ZONTX  BYBWT  GONEY  CUZWR GDSON  SXBOU  YWRHE  BAAHY  USEDQ"; // Playfair, ROYAL NEW ZEALAND NAVY; ROYALNEWZDV //
            // PT BO AT ON EO WE NI NE LO ST IN AC TI ON IN BL AC KE SU ST RA IT TW OM IL ES SW ME RE SU CO CE XC RE WO FT WE LV EX RE QU ES TA NY IN FO RM AT IO NX
            // PT BO AT ON EO WE NI NE LO ST IN AC TI ON IN BL AC KE II ST RA IT TW OM IL ES SW ME RE SU CO CE XC RE WO FT WE LV EX RE QU ES TA NY IN FO RM AT IO NX
            // PT BOAT ONE OWE NINE LOST IN ACTION IN BLACKETT STRAIT TWO MILES SW MERESU COVE X CREW OF TWELVE X REQUEST ANY INFORMATION !!!

            //Caesar.Print.DecryptCryptanalytic(i2);

            var T1 = "PT BOAT ONE OWE NINE LOST IN ACTION IN BLACKETT STRAIT TWO MILES SW MERESU COVE X CREW OF TWELVE X REQUEST ANY INFORMATION"; // PERE
            var T2 = "EX SSPX FRT SNI CMEI ASJX XR RGIMFR XR SPPGBIIX JXGEZX IAF QXPVW HA DIGIJY RSMI M GIIL SW XLICZT B IIFYVWI EEC XRWSGQRXXSE";

            //Vigenere.Print.Encrypt(T1, "PERE");

            CombGen comb = new CombGen();
            comb.Generate(4, CombGen.AlphabetUp);
            IEnumerable<string> combList = comb.LastGenerate;

            Vigenere.Print.DectyptBruteforce(T2, combList, 50);

            Console.WriteLine();


            //Vigenere.Print.Decrypt(i1, k1);

            //Playfair.Print.Decrypt(i3, k2);

            //WordsAnalyzer.Print.EnglishWords();

            //Console.WriteLine(WordsAnalyzer.GetMatchesNumber("Just to note here. Regex is slower on small strings! If you say you had a digitized version of a Volume on US Tax Law million words with a handful of iterations Regex is king by far Its not what is faster but what should be used in which circumstance"));
            //Console.WriteLine(WordsAnalyzer.GetMatchesNumber("Qbza av uval olyl. Ylnle pz zsvdly vu zthss zaypunz! Pm fvb zhf fvb ohk h kpnpapglk clyzpvu vm h Cvsbtl vu BZ Ahe Shd tpsspvu dvykz dpao h ohukmbs vm palyhapvuz Ylnle pz rpun if mhy Paz uva doha pz mhzaly iba doha zovbsk il bzlk pu dopjo jpyjbtzahujl"));

            //Stopwatch stopwatch = new Stopwatch();

            //stopwatch.Start();
            //Console.WriteLine(WordsAnalyzer.GetMatchesNumber("PT BOAT ONE OWE NINE LOST IN ACTION IN BLACKETT STRAIT TWO MILES SW MERESU COVE X CREW OF TWELVE X REQUEST ANY INFORMATION"));
            //Console.WriteLine(WordsAnalyzer.GetMatchesNumber(i3));
            //stopwatch.Stop();

            //Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}
