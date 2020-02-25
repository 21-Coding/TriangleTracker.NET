using System;
using System.Collections.Generic;

public class Triangle
{
    public int Side1;
    public int Side2;
    public int Side3;
    public Triangle(int side1, int side2, int side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
}

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Enter side 1: ");
        string stringSide1 = Console.ReadLine();
        int intSide1 = int.Parse(stringSide1);

        Console.WriteLine("Enter side 2: ");
        string stringSide2 = Console.ReadLine();
        int intSide2 = int.Parse(stringSide2);

        Console.WriteLine("Enter side 3: ");
        string stringSide3 = Console.ReadLine();
        int intSide3 = int.Parse(stringSide3);

        Triangle userTriangle = new Triangle(intSide1, intSide2, intSide3);
        TriangleTracker();

        void TriangleTracker()
        {
            if (userTriangle.Side1 + userTriangle.Side2 <= userTriangle.Side3 || userTriangle.Side2 + userTriangle.Side3 <= userTriangle.Side1 || userTriangle.Side3 + userTriangle.Side1 <= userTriangle.Side2)
            {
                Console.WriteLine("Not a Triangle! Try again!");
            }
            else if (userTriangle.Side1 == userTriangle.Side2 && userTriangle.Side2 == userTriangle.Side3)
            {
                Console.WriteLine("You have an Equilateral Triangle!");
            }
            else if (userTriangle.Side1 == userTriangle.Side2 && userTriangle.Side2 != userTriangle.Side3 || userTriangle.Side1 == userTriangle.Side3 && userTriangle.Side1 != userTriangle.Side2 || userTriangle.Side2 == userTriangle.Side3 && userTriangle.Side2 != userTriangle.Side1)
            {
                Console.WriteLine("You have an Isosceles Triangle!");
            }
            else if (userTriangle.Side1 != userTriangle.Side2 && userTriangle.Side2 != userTriangle.Side3 && userTriangle.Side3 != userTriangle.Side1)
            {
                Console.WriteLine("You have an Scalene Triangle!");
            }
        }
    }
}
