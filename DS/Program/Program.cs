using System;

using DS.Caesar;
using DS.Playfair;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //                COSTEL MERGE LA CUMPARATURI
            string set1_form = "CO ST EL ME RG EL AC UM PA RA TU RI";
            string set1_brut = "Costel merge la cumparaturi";

            string key = "CORNEL";

            string set2_form = "AN AX RE ME RE SI GU TU IX";
            string set2_brut = " Ana are mere Si gutui ";

            string encrypteed = "DO BW NC UF NC XS MP UP SR";

            Console.WriteLine(
                Playfair_cipher.Encipher( set2_brut , key) + "\n" + 
                Playfair_cipher.Decipher( encrypteed, key )

            );
        }
    }
}
