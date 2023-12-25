using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_chess_find_the_queen
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] chess = new char[,] 
            {
                { 'C', 'R', 'B', 'Q', 'K', 'B', 'R', 'C' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'C', 'R', 'B', 'Q', 'K', 'B', 'R', 'C' },
            };

            for( int y = 0; y < chess.GetLength(0); y++ )
            {
                for (int x = 0; x < chess.GetLength(1); x++)
                {
                    
                    if(chess[x, y] == 'Q')
                    {
                        Console.WriteLine("The location of the queen is " + x + ", " + y);
                    }

                }
            }


            Console.ReadLine();

        }
    }
}
