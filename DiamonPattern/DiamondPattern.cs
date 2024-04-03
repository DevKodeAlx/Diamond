using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamonPattern
{
    internal class DiamondPattern
    {
        static void Main(string[] args)
        {

            int rows;

            Console.WriteLine("Enter the number of rows for the diamond: ");
            // "Parse" translates text to a usable format for the program. //
            rows = int.Parse(Console.ReadLine());

            // *** UPPER PART OF DIAMOND *** //

            for (int i = 1; i <= rows; i++)
            {
                // Prints spaces.//
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Prints stars in the upper half of the diamond.//
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // *** LOWER PART OF DIAMOND *** //
            for (int i = rows - 1; i >= 1; i--)
            {
                // Prints spaces.//
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Prints the stars in the lower half of the diamond.//
                for(int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
       
    }
}
