using System;
class FLoyd
{
    static void Main(string[] args)
    {
        int count = 1;
        Console.Write("Enter no of rows:");
        int row=Convert.ToInt32(Console.ReadLine());
        int[,]a=new int[row,row];
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                a[i, j] = count++;
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
           
        }
    }
}