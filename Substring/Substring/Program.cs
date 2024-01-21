using System;

class Substring
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string str = Console.ReadLine()!;

        for (int i = 1; i <= str.Length; i++)
        {
            for (int j = 0; j <= str.Length - i; j++)
            {
                Console.Write(str.Substring(j, i));
                Console.WriteLine();
            }
            
        }
    }
}