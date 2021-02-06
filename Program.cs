using System;
using static System.Console;

namespace MultiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationtable = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    multiplicationtable[i, j] = (i + 1) * (j + 1);
                }

            }

            WriteLine();
        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Write(multiplicationtable[i,j]+ "\t");
                }
                WriteLine();

            }
            WriteLine();
        }
    }
}



//     int[,] multiplicationTable = new int[10, 10];
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             multiplicationTable[i, j] = (i + 1) * (j + 1);
//         }
//     }
//     WriteLine();
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             Write(multiplicationTable[i, j] + "\t");
//         }

//         WriteLine();

//     }
//     WriteLine();
