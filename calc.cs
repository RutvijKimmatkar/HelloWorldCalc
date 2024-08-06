class Program
{
    static void add(int num1, int num2)
    {
        Console.WriteLine("Answer is: "+ (num1 + num2));
    }
    static void sub(int num1, int num2)
    {

        Console.WriteLine(num1 - num2);
    }
    static void Main()
    {
        Console.WriteLine("select operation, 1.Addition 2.Subtraction");
        int operation = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (operation == 1)
        {
            add(num1, num2);
        }
        else if (operation == 2)
        {
            sub(num1, num2);
        }
        else
        {
            Console.WriteLine("invalid operation selected");
        }

    }
}
