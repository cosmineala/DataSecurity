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
            var t1 = "KVKTG LPZGS JUAIR KUNPB VZFIO OJVKV IPHZG TSLLV ATSXT OCKLG UVTKZ";

            var t2 = "MIHYU OTPDI FLRYD IPDYH NFCIW DFGFC UOVEL GYDOT DYATN AEPQL DNSHT BYERZ UMCXO YIDOS HYISF ETFHF CEIGH YUMWD TFFCH IVIWO LFRZI CDITC OYETB RNFIL QLIP";

            var t3 = "VIZIZ MBZOD XHVIR DGGNP XXZZY RCZMZ VIDIY JGZIO JIZRJ PGYQZ BZOVO ZVIYD IZQDO VWGTK ZMDNC";
            // AEMWSWAIOWVAIP
            var k3 = "AEMWSWAIOWVAIP";

            var t4 = "FVCHE DWIXM BMVOV TMLZU HHEZK WCHZC SMFOU HOEGT UUQVZ FPHDE OHPTO WNILX";
            var k4 = "CNRTLONEFIO";

            var t5 = "TLQOW WDWSO IOBQX SSFKT RRIKC CMTYA CAOMG VYJUO VWGTB PIGKL CCQEZ IDGVU EHFCC DEPXA JHQYL NGNUJ HYEWF TBNLK MSPZS PISNB WIITT FGQIF EOALZ JXJTV IZIVT NIYHP HYKSIJ";
            // THESE ADOES NOTBE LONGT ODESP OTSUP ONITS SURFA CEMEN CANST ILLEX ERCIS EUNJU STLAW SFIGH TTEAR ONEAN OTHER TOPIE CESAN DBECA RRIED AWAYW ITHTE RREST RIALH ORRORS
            var k5 = "TSDNBTDUISMCSEULFTOATPABCAWTH";


            var t6 = "YINCI DHPVA MQKDL XPKVM ABGWP GHNGM GYPKF AMQPO KPENW BSPQI ZTWAP UQAMD MWPAC DCLXY";
            // WITHHAPPINESSASWITHHEALTHTOENIOYITONESHOULDBEDEPRIVEDOFITOCCASIONALLZS
            var k6 = "WHAWHTEIOSBDOIO";

            //Caesar.Print.DecryptCryptanalytic(t3); // Done

            //Console.WriteLine(DWord.ToAlphabetKeyFull(k3)); //Completeza cu alfabetul full
            //Console.WriteLine( Playfair.ToPlayfairKeyFull("")); // Completeaza cu alfabetul playfair (i/j)

            Vigenere.Print.AutoDecrypt(t1, k3);
            //Playfair.Print.Decrypt(t2, k1);

            //Square4 square4 = new Square4(k6, "", "");
            //square4.matrix.PrintMatrix();


        }
    }
}


