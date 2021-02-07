using DS.Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Playfair
{
    public class Matrix
    {
        public static Matrix DefaultMatrig { get; } = new Matrix(5, 5, "");

        static public Matrix operator - (Matrix a, Matrix b)
        {
            int x = a.x;
            int y = a.y + b.y;

            Matrix outut = new Matrix(x, y);
            
            for( int i = 0; i < a.x; i ++)
            {
                for( int j = 0; j < a.y; j++)
                {
                    outut.matrix[i, j] = a.matrix[i, j];
                }
            }

            for (int i = 0; i < b.x; i++)
            {
                for (int j = 0; j < b.y; j++)
                {
                    outut.matrix[i, j + a.y] = b.matrix[i, j];
                }
            }

            return outut;
        }


        static public Matrix operator | (Matrix a, Matrix b)
        {
            int x = a.x + a.x;
            int y = a.y;

            Matrix outut = new Matrix(x, y);

            for (int i = 0; i < a.x; i++)
            {
                for (int j = 0; j < a.y; j++)
                {
                    outut.matrix[i, j] = a.matrix[i, j];
                }
            }

            for (int i = 0; i < b.x; i++)
            {
                for (int j = 0; j < b.y; j++)
                {
                    outut.matrix[i + a.x, j] = b.matrix[i, j];
                }
            }

            return outut;
        }

        //#####

        public char[,] matrix;
        public int x, y;

        string key;

        public Matrix(string key)
        {
            this.x = 5;
            this.y = 5;
            matrix = new char[x, y];

            PopulateMatrix(key);
        }

        public Matrix(int x, int y)
        {
            this.x = x;
            this.y = y;
            matrix = new char[x, y];
        }
        public Matrix(int x, int y, string key)
        {
            this.x = x;
            this.y = y;
            matrix = new char[x, y];

            PopulateMatrix(key);
        }

        public void PopulateMatrix( string key)
        {
            this.key = Playfair.ToPlayfairKeyFull(key);

            int keyCount = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    this.matrix[i, j] = this.key[keyCount++];
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.x; i++)
            {
                for (int j = 0; j < this.y; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Tuple<int,int> GetCharPosition( char ch)
        {
            for( int i = 0; i < this.x; i++ )
            {
                for( int j = 0; j < this.y; j++ )
                {
                    if(matrix[i,j] == ch)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            throw new Exception("Letter was not founded in the matrix");
        }

        //public Tuple<int,int> GetPositionBelowPosition( int x, int y)
        //{
        //    if ( this.x + 1 == x)
        //    {
        //        return new Tuple<int, int>(0, y);
        //    }
        //    else
        //    {
        //        return new Tuple<int, int>(x + 1 , y);
        //    }
        //}

        public Tuple<int, int> GetPositionDown(int x, int y) =>
            new Tuple<int, int>((x + 1) % this.x, y);

        public Tuple<int, int> GetPositionUp(int x, int y)
        {
            if (x - 1 >= 0)
                return new Tuple<int, int>(x - 1, y);
            else
                return new Tuple<int, int>(this.x - 1, y);
        }

        public Tuple<int, int> GetPositionRight(int x, int y) =>
            new Tuple<int, int>(x, ( y + 1 ) % this.y );

        public Tuple<int, int> GetPositionLeft(int x, int y)
        {
            if (y - 1 >= 0)
                return new Tuple<int, int>( x , y - 1 );
            else
                return new Tuple<int, int>( x , this.y - 1 );
        }

    }
}
