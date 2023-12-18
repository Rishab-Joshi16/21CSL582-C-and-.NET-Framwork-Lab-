using System;
class Calc
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter operator(+,-,*,/,%)");
        char op= Convert.ToChar(Console.ReadLine()!);
        Console.Write("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        switch(op)
        {
            case '+':Console.WriteLine($"{a} {op} {b} = " + (a + b));
                     break;

            case '-':Console.WriteLine($"{a} {op} {b} = " + (a - b));
                break;

            case '*':Console.WriteLine($"{a} {op} {b} = " + (a * b));
                break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Divide by zero error enter different number for b");
                }
                Console.WriteLine($"{a} {op} {b} = " + (a / b));
                break;
            case '%':
                if (b == 0)
                {
                    Console.WriteLine("Divide by zero error enter different number for b");
                }
                Console.WriteLine($"{a} {op} {b} = " + (a % b));
                break;
            default: Console.WriteLine("INvalid operator please try again");
                    break;
        }

    }
}