using System;


class Program
{
    static void Main(string[] args)
    {
        var sizeRhombus = int.Parse(Console.ReadLine());
        for (int rowSize = 1; rowSize <= sizeRhombus; rowSize++)
        {
            PrintRow(sizeRhombus, rowSize);
        }
        for (int rowSize = sizeRhombus - 1; rowSize > 0; rowSize--)
        {
            PrintRow(sizeRhombus, rowSize);
        }
    }

    static void PrintRow(int sizeRhombus, int rowSize)
    {
        for (int counter = 0; counter < sizeRhombus-rowSize; counter++)
        {
            Console.Write(" ");
        }
        for (int counter = 0; counter < rowSize; counter++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
  