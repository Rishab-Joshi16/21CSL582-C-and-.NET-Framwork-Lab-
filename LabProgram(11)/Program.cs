using System;
abstract class Shape
{
    public abstract double area();
    public abstract double perimeter();
}
class Circle : Shape
{
    public double r;
    public Circle(double r)
    {
        this.r = r;
    }
    public override double area()
    {
        return Math.PI * this.r*this.r;
    }
    public override double perimeter()
    {
        return Math.PI*this.r*2;
    }
}
class Triangle : Shape
{
    double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double area()
    {
        double s= (this.a+this.b+this.c)/2;
        return Math.Sqrt(s*(s-this.a)*(s-this.b)*(s-this.c));
    }
    public override double perimeter()
    {
       return this.a + this.b +this.c;
     }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter radius:");
        double r=Convert.ToDouble(Console.ReadLine());
        Circle c1 = new Circle(r);
        Console.WriteLine($"Area= {c1.area()}");
        Console.WriteLine($"Perimeter= {c1.perimeter()}");

        Console.WriteLine("Enter 3 sides of trangle:");
        double a=Convert.ToDouble(Console.ReadLine());
        double b=Convert.ToDouble(Console.ReadLine());
        double c=Convert.ToDouble(Console.ReadLine());
        Triangle t = new Triangle(a, b, c);
        Console.WriteLine($"Area= {t.area()}");
        Console.WriteLine($"Perimeter= {t.perimeter()}");

    }
}
