namespace AdvancedPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;

            Console.Write("Enter the number of rows: ");
            if (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            Console.Write("Enter the number of columns: ");
            if (!int.TryParse(Console.ReadLine(), out cols))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    (int row, int col) position = (i, j);

                    // Use pattern matching to determine the character based on position
                    char symbol = position switch
                    {
                        (int evenRow, int evenCol) when evenRow % 2 == 0 && evenCol % 2 == 0 => 'X',
                        (int evenRow, int oddCol) when evenRow % 2 == 0 && oddCol % 2 != 0 => 'O',
                        (int oddRow, int evenCol) when oddRow % 2 != 0 && evenCol % 2 == 0 => 'O',
                        (int oddRow, int oddCol) when oddRow % 2 != 0 && oddCol % 2 != 0 => 'X',
                        _ => throw new ArgumentException("Invalid position"),
                    };

                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
           
        }
        
    }
}