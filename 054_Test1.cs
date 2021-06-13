using System;

namespace _054_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];
            int zeroRow = 0;
            int zeroColumn = 0;
            int i = 0;
            int j = 0;
            int check = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == 0)
                    {
                        zeroRow = i;
                        zeroColumn = j;
                    }
                    table[i, j] = number;
                }
            }
            // show table
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            int Substitute = int.Parse(Console.ReadLine());
            table[zeroRow, zeroColumn] = Substitute;

            // Check Row
            for (i = 0; i < 3; i++)
            {
                if (table[i, zeroColumn] == Substitute)
                {
                    check += 1;
                }
            }

            // Check Column
            for (j = 0; j < 3; j++)
            {
                if (table[zeroRow, j] == Substitute)
                {
                    check += 1;
                }
            }

            if (check >= 3)
            {
                Console.WriteLine("The number is available");
            }
            // show new table
            else
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(table[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
