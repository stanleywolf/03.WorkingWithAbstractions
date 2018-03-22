using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var coord = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var rectangle = new Rectangle(coord[0], coord[1], coord[2], coord[3]);
        var pointsCount = int.Parse(Console.ReadLine());

        for (int pointCounter = 0; pointCounter < pointsCount; pointCounter++)
        {
            var pointCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point = new Point(pointCoords[0],pointCoords[1]);
            var containPoint = rectangle.Contains(point);
            Console.WriteLine(containPoint);
        }
    }
}