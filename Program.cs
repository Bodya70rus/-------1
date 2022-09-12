
namespace ЛР1
{
    class Program
    {
        static void Initialing(ref int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i == 1 && ((j >= 1 && j <= 10) || (j >= 14 && j <= 20))) ||
                        (i == 12 && ((j >= 1 && j <= 10) || (j >= 14 && j <= 23))) ||
                        (i == 23 && ((j >= 1 && j <= 10) || (j >= 14 && j <= 23))) ||
                        ((j == 1 || j == 14) && (i != 0 && i != 24)) ||
                        (j == 10 && ((i >= 1 && i <= 3) || (i >= 12 && i <= 23))) ||
                        (j == 20 && i >= 1 && i <= 12) ||
                        (j == 23 && i >= 12 && i <= 23))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[25, 25];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 9);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            Initialing(ref matrix);
            PrintMatrix(matrix);

            Console.ReadKey();
        }
    }
}