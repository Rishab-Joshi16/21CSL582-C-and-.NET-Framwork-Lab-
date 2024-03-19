using System;
class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("Drawing shape");
    }
    public virtual void erase() { 
        Console.WriteLine("Erasing shape"); 
    }

}
class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Circle");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing Circle");
    }

}
class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing Triangle");
    }
}
class Square : Shape {
    public override void draw()
    {
        Console.WriteLine("Drawing Square");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing Square");
    }
}

class Display
{
    public static void Main(string[] args)
    {
        Shape[] sh = new Shape[4];
        sh[0]=new Shape();
        sh[1]=new Circle();
        sh[2]=new Triangle();
        sh[3]=new Square();
        for (int i = 0; i < sh.Length; i++)
        {
            sh[i].draw();
            sh[i].erase();
        }
    }
}

