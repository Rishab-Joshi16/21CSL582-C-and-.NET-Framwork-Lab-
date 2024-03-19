using System;

class Complex
{
    public double real, imaginary;
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public static Complex operator +(Complex x, Complex y) {
        double realpart=x.real+y.real;
        double imagpart=x.imaginary+y.imaginary;
        return new Complex(realpart, imagpart);
    }
    public void display()
    {
        Console.WriteLine($"Result : {real}+{imaginary} i");
    }
    public static void Main()
    {
        Console.WriteLine("Enter real part of c1: ");
        double r1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter imaginary part of c1:");
        double img1=Convert.ToDouble(Console.ReadLine());
        Complex obj=new Complex(r1, img1);
        Console.WriteLine("Enter real part of c2: ");
        double r2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter imaginary part of c2:");
        double img2 = Convert.ToDouble(Console.ReadLine());
        Complex obj2= new Complex(r2, img2);
        Console.WriteLine($"First Complex number is {r1} + {img1} i");
        Console.WriteLine($"Second Complex number is {r2} + {img2} i");
        Complex c1=new Complex(r1, img1);
        Complex c2=new Complex(r2, img2);
        Complex result = c1 + c2;
        result.display();
    }
}
