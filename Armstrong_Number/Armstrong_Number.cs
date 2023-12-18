using System;
class Armstrong
{
    static void Main()
    {
        Console.WriteLine("Aromstrong numbers from 1 to 1000");
        for (int i = 1; i <= 1000; i++) {
            int temp = i;
            int cnt = 0;
            while (temp != 0)
            {
                cnt++;
                temp = temp / 10;
            }
            int sum = 0;
            int temp2 = i;
            while(temp2 != 0)
            {
                temp=temp2 % 10;
                sum = sum + (int)Math.Pow(temp, cnt);
                temp2 = temp2 / 10;
            }
            
            if (i == sum)
            {
                Console.WriteLine(i);
            }

        }
    }
}