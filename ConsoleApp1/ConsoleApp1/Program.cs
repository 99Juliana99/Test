abstract class GeomFigure
{

    abstract public double sFigure();
    abstract public double pFigure();
}
class Triangle : GeomFigure
{
    double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double sFigure()
    {
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    public override double pFigure()
    {
        return (a + b + c);

    }
}

class Square : GeomFigure
{
    double a;
    public Square(double a)
    {
        this.a = a;

    }
    public override double sFigure()
    {
        return a * a;
    }
    public override double pFigure()
    {
        return 4 * a;
    }
}

class Rhombus : GeomFigure
{
    double a, b, c;
    public Rhombus(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double sFigure()
    {

        return b * c / 2;
    }
    public override double pFigure()
    {
        return 4 * a;
    }
}

class Rectangle : GeomFigure
{
    double a, b;
    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public override double sFigure()
    {
        return a * b;
    }
    public override double pFigure()
    {
        return (a + b) * 2;
    }
}

class Parallel : GeomFigure
{
    double a, h, b;
    public Parallel(double a, double h, double b)
    {
        this.a = a;
        this.h = h;
        this.b = b;
    }
    public override double pFigure()
    {
        return 2 * (a + b);
    }
    public override double sFigure()
    {
        return a * h;
    }
}

class Trapezium : GeomFigure
{
    double a, b, c, d, h;
    public Trapezium(double a, double b, double c, double d, double h)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.h = h;
    }
    public override double sFigure()
    {
        return ((a + b) / 2) * h;
    }
    public override double pFigure()
    {
        return a + b + c + d;
    }
}

class Circle : GeomFigure
{
    double r;
    public Circle(double r)
    {
        this.r = r;
    }
    public override double sFigure()
    {
        return 3.14 * (r * r);
    }
    public override double pFigure()
    {
        return 2 * 3.14 * r;
    }
}

class Ellipse : GeomFigure
{
    int a, b;
    public Ellipse(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public override double sFigure()
    {
        return 3.14 * a * b;
    }
    public override double pFigure()
    {
        return a + b;
    }