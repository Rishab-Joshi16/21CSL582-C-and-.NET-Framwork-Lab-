using System;
interface Resizable
{
    void ResizableWidth(int width);
    void ResizableHeight(int height);
}
class Rectangle : Resizable {
    private int width;
    private int height;
    public Rectangle(int width,int height)
    {
        this.width = width;
        this.height = height;
    }
    public void Display()
    {
        Console.WriteLine($"Rectangle width: {width}, height: {height}");
    }
    public void ResizableWidth(int newwidth) {
        width = newwidth;
        Console.WriteLine($"Resized width to {width}");
    }
    public void ResizableHeight(int newHeight) {  
        height = newHeight;
        Console.WriteLine($"Resized height to {height}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter width:");
        int width=Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Enter height:");
        int height = Convert.ToInt32(Console.ReadLine());
        Rectangle r=new Rectangle(width,height);
        Console.WriteLine("Original size");
        r.Display();
        Console.WriteLine("Enter new width:");
        int newwidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter new height:");
        int newheight = Convert.ToInt32(Console.ReadLine());
        r.ResizableWidth(newwidth);
        r.ResizableHeight(newheight);
        Console.WriteLine("Updated Size: ");
        r.Display();


    }
}

