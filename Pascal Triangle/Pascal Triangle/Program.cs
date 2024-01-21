using System;
class Pascal
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows: ");
        int rows=Convert.ToInt32(Console.ReadLine());
        int[,] pascal = new int[rows+1, rows+1];
        for(int i = 0; i <= rows; i++)
        {
            for(int blank=0; blank <= rows-i; blank++)
                Console.Write(" ");
            for(int j=0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    pascal[i, j] = 1;
                }
                else
                {
                    pascal[i, j] = pascal[i-1, j]+ pascal[i-1,j-1];
                    
                }
                Console.Write(pascal[i, j] + " ");
                
            }
            Console.WriteLine();
        }
    }
}
