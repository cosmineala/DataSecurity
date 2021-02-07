using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Playfair
{
    public class Square4
    {
        public Matrix matrix;

        public Matrix A,B,C,D;
        //    A  B
        //    C  D

        string message;

        public Square4( string k1, string k2, string message)
        {
            A = Matrix.DefaultMatrig;
            B = new Matrix(k1);
            C = new Matrix(k2);
            D = Matrix.DefaultMatrig;

            this.matrix = ( A - B ) | ( C - D );
            this.message = Playfair.Decrypt(message, k1);
        }

        public string ChEncrypt( string chPair)
        {
            // get the position in the local matix
            var p1 = A.GetCharPosition(chPair[0]); 
            var p2 = D.GetCharPosition(chPair[1]);

            // compute the position in the global matrix
            p1 = new Tuple<int, int>(p1.Item1, p1.Item2);
            p2 = new Tuple<int, int>(p2.Item1 + 5 , p1.Item2 + 5);

            var a1 = new Tuple<int, int>( p1.Item1, p2.Item2 );
            var a2 = new Tuple<int, int>( p2.Item1, p1.Item2 );

            return "" + matrix.matrix[a1.Item1, a1.Item2] + matrix.matrix[a2.Item1, a2.Item2];
        }

        public void PrintDecript() =>
            Console.WriteLine(message.ToUpper());
      
        public void PrintEecript() =>
            Console.WriteLine(message.ToUpper());


    }
}