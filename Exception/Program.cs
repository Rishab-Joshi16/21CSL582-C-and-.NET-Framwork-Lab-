using System;

class Exceptions
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter numerator: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter denomirator: ");
        int b = Convert.ToInt32(Console.ReadLine());
        try
        {
            int res = a / b;
            Console.WriteLine($"Division of {a} by {b} is {res}");
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter elements: ");
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter index to be displayed: ");
        int index = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine(arr[index]);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }


    }
}
