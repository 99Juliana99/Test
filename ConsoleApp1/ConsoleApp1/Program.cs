using System;

Square square = new Square(1);
int calculatedSquareForSquare = square.CalculateSquare();
Console.WriteLine($"Result of calculation square for square with side '{square.Side}' = {calculatedSquareForSquare}");

Triangle triangle = new Triangle(4, 4, 4);
double calculatedSquareForTriangle = triangle.CalculateSquare();
Console.WriteLine($"Result of calculation square for triangle with sides '{triangle.Side1}', '{triangle.Side2}', '{triangle.Side3}' = {calculatedSquareForTriangle}");

Rectangle rectangle = new Rectangle(5, 6);
int calculatedSquareForRectangle = rectangle.CalculateSquare();
Console.WriteLine($"Result of calculation square for rectangle with sides '{rectangle.Side1}', '{rectangle.Side2}' = {calculatedSquareForRectangle}");

Circle circle = new Circle(7);
double calculatedSquareForCircle = circle.CalculateSquare();
Console.WriteLine($"Result of calculation square for circle with radius '{circle.Radius}' = {calculatedSquareForCircle}");

public static class FigureHelper
{
    public static int CalculateSquare(this Square square)
    {
        return square.Side * square.Side;
    }

    public static double CalculateSquare(this Triangle triangle)
    {
        double p = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;
        return Math.Sqrt(p * (p - triangle.Side1) * (p - triangle.Side2) * (p - triangle.Side3));
    }

    public static int CalculateSquare(this Rectangle rectangle)
    {
        return rectangle.Side1 * rectangle.Side2;
    }

    public static double CalculateSquare(this Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }
}

public abstract class Figure
{
}

public class Square : Figure
{
    public int Side;

    public Square(int side)
    {
        this.Side = side;
    }
}

public class Triangle : Figure
{
    public int Side1;
    public int Side2;
    public int Side3;


    public Triangle(int side1, int side2, int side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }
}

public class Rectangle : Figure
{
    public int Side1;
    public int Side2;


    public Rectangle(int side1, int side2)
    {
        this.Side1 = side1;
        this.Side2 = side2;
    }


}

public class Circle : Figure
{
    public int Radius;

    public Circle(int radius)
    {
        this.Radius = radius;
    }
}
