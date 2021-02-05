using DS.Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Playfair
{
    public class Matrix
    {
        char[,] matrix;
        int x, y;

        string key;
        public Matrix(int x, int y)
        {
            matrix = new char[x, y];
        }
        public Matrix(int x, int y, string key)
        {
            this.x = x;
            this.y = y;
            matrix = new char[x, y];

            this.key = Playfair.ToPlayfairKeyFull(key);

            int keyCount = 0;

            for( int i = 0; i < x; i++ )
            {
                for( int j = 0; j < y; j++)
                {
                    this.matrix[i, j] = this.key[keyCount++];
                }
            }

            // Print for debug
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
