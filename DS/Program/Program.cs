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
            // Fisierele se gasesc in folderul DS/Inputs ( nu in folderul DS care contine codul, in folderul DS care contine solutia si toate proiectele )
            // Fisierele de intrare trebuie sa contina parola pe primul rand si testul pe urmatorul rand
            // Fisierele de iesire au "--Beaufort...." dupa numele mostemnit de la fisierul original si au acceasi structura

            var i1 = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING"; // text in clar
            var i2 = "OEZEL KRIHD QAFRO ZIMLL GMPBT HEALT ZQNRP GBSPT ZPBAF QFFGQ"; // varianta criptata a textului in clar 

            var k  = "DINTWOFNTHTITTF"; // key

            Vigenere.Print.BeaufortEncrypt(i1, k); // print in consola
            Vigenere.Print.BeaufortDecrypt(i2, k);

            Vigenere.File.BeaufortEncrypt("DeCriptat_1.txt"); // output de fisier
            Vigenere.File.BeaufortDecrypt("DeDecriptat_2.txt");
        }
    }
}
