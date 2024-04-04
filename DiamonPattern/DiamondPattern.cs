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
            while (true) // This while loop will cause the program to run continuously. //
            {

                int rows;
                Console.Write("Enter the number of rows for the diamond: ");
                
                rows = int.Parse(Console.ReadLine()); // "Parse" translates text to a usable format for the program. //
                Console.WriteLine();

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
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                Console.ReadLine();
                Main(args); // Call the main function to start over. //



            }
        }
    }
}
