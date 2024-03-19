using System;

class StackOp
{
    private int MAX;
    private int[] stack;
    private int top;

    public StackOp(int MAX)
    {
        this.MAX = MAX;
        this.stack = new int[this.MAX];
        Top = -1;
    }

    public int Top
    {
        get { return top; }
        set { top = value; }
    }

    public void Push()
    {
        if (Top + 1 >= this.MAX)
            Console.WriteLine("Stack Overflow");
        else
        {
            Console.WriteLine("Enter element to be pushed:");
            int x = Convert.ToInt32(Console.ReadLine());
            stack[++Top] = x;
        }
    }

    public void Pop()
    {
        if (Top == -1)
            Console.WriteLine("Stack Underflow");
        else
        {
            Console.WriteLine("Deleted element is " + stack[Top]);
            Top--;
        }
    }

    public void Display()
    {
        Console.Write("Elements of stack are:");
        for (int i = 0; i <= Top; i++)
        {
            Console.WriteLine(stack[i]);
        }
    }
}

class MainFunc
{
    static void Main(string[] args)
    {
        Console.Write("Enter stack size:");
        int MAX = Convert.ToInt32(Console.ReadLine());
        StackOp obj = new StackOp(MAX);
        while (true)
        {
            Console.WriteLine("\n1.Push\n2.Pop\n3.Display\n4.Exit");
            Console.WriteLine("Enter choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    obj.Push();
                    break;
                case 2:
                    obj.Pop();
                    break;
                case 3:
                    obj.Display();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
