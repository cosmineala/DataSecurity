using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Dictionary
{
    public class LetterCounter
    {
        class Letter
        {
            public char letter;
            public int amount;
            public void Add()
            {
                amount++;
            }
        }

        List<Letter> letters = new List<Letter>();
        int tottalCount = 0;

        public LetterCounter(string inputString)
        {
            foreach (char letter in inputString)
            {
                this.addToList(letter);
            }
        }

        void addToList(char letter)
        {
            if (IsLetter(letter) == false)
            {
                return;
            }

            tottalCount++;
            foreach (Letter letterElement in letters)
            {


                if (letter == letterElement.letter)
                {
                    letterElement.Add();
                    return;
                }
            }
            letters.Add(new Letter { letter = letter, amount = 1 });
        }
        bool IsLetter(char letter)
        {
            if ((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void sortByAmount()
        {
            letters.Sort((x, y) => y.amount.CompareTo(x.amount));
        }
        public void sortByAlphabet()
        {
            letters.Sort((x, y) => x.letter.CompareTo(y.letter));
        }

        public void print()
        {
            Console.Write(this.ToString());
        }

        public string ToString()
        {
            string output = "";

            foreach (Letter letter in letters)
            {
                output += " \"" + letter.letter + "\" : " + letter.amount + "\t" + calculateProcentage(letter.amount) + "%\n";
            }
            return output;
        }

        public string ToStringForFile()
        {
            string output = "";
            output += "\tLetter\ttimes\t%\tGraph\n";

            foreach (Letter letter in letters)
            {
                output += "\t\"" + letter.letter + "\"\t " + letter.amount + "  \t" + calculateProcentage(letter.amount) + " \t | ";
                for (int i = 0; i < letter.amount; i++)
                {
                    output += "#";
                }
                output += "\n";
            }
            return output;
        }

        float calculateProcentage(int amount)
        {
            return ((int)(100 * ((100f * amount) / this.tottalCount))) / 100f;
        }

    }

}
//                               a  b  c  d  e  f  g  h  i  j  k  l  m  n  o  p  q  r  s  t  u  v  w  x  y  z
// a  b  c  d  e  f  g  h  i  j  k  l  m  n  o  p  q  r  s  t  u  v  w  x  y  z  a  b  c  d  e  f  g  h  i  j  k  l  m  n  o  p  q  r  s  t  u  v  w  x  y  z 
// 0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25

// shift +16
// YVOEK MQDJJ EIKSS UUTOE KIXEK BTIJH YAUEK JEDDU MFQJX IHQJX UHJXQ DJHQL UBJXU MEHDF QJXIE VQSSUF JUTIK SSUII
// IFYOU WANTT OSUCC EEDYO USHOU LDSTR IKEOU TONNE WPATH SRATH ERTHA NTRAV ELTHE WORNP ATHSO FACCEP TEDSU CCESS
// IF YOU WANT TO SUCCEED YOU SHOULD STRIKE OUT ON NEW PATHS RATHER THAN TRAVEL THE WORN PATHS OF ACCEPTED SUCCESS

//Engleza:
 // Letter    Count	| 	Letter	Frequency 
	// E	    21912	| 	E	    12.02
	// T	    16587	| 	T	    9.10
	// A	    14810	| 	A	    8.12
	// O	    14003	| 	O	    7.68
	// I	    13318	| 	I	    7.31
	// N	    12666	| 	N	    6.95
	// S	    11450	| 	S	    6.28
	// R	    10977	| 	R	    6.02
	// H	    10795	| 	H	    5.92
	// D	    7874	| 	D	    4.32
	// L	    7253	| 	L	    3.98
	// U	    5246	| 	U	    2.88
	// C	    4943	| 	C	    2.71
	// M	    4761	| 	M	    2.61
	// F	    4200	| 	F	    2.30
	// Y	    3853	| 	Y	    2.11
	// W	    3819	| 	W	    2.09
	// G	    3693	| 	G	    2.03
	// P	    3316	| 	P	    1.82
	// B	    2715	| 	B	    1.49
	// V	    2019	| 	V	    1.11
	// K	    1257	| 	K	    0.69
	// X	    315	 	|   X	    0.17
	// Q	    205	 	|   Q	    0.11
	// J	    188	 	|   J	    0.10
	// Z	    128	 	|   Z	    0.07


//Romana: (oridene deoarece nu avem destule date)

//  E
//  A  ( A si I sunt aproape identice)
//  I
//  R
//  N
//  U
//  T
//  C
//  L   ( L si S )
//  S
//  Ă
// ....
