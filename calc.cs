class Program
{
    static int add(int num1, int num2)
    {
        Console.Write(num1 + "+" + num2 + "=");
        return num1 + num2;
    }
    static int sub(int num1, int num2)
    {
        Console.Write(num1 + "-" + num2 + "=");
        return num1 - num2;
    }
    static int division(int num1, int num2)
    {
        Console.Write(num1 + "/" + num2 + "=");
        return num1 / num2;
    }
    static int multi(int num1, int num2)
    {
        Console.Write(num1 + "x" + num2 + "=");
        return num1 * num2;
    }



    static void Main()
    {
      
        Console.WriteLine("Welcome to Calculator. Select an operation.");
        Console.WriteLine("1. Addition 2.Subtraction 3.Division 4.Multiplication");
        int operation = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 1:
                Console.WriteLine("Selected Addition");
                int sum = add(num1, num2);
                Console.Write(sum);
                break;
            case 2:
                Console.WriteLine("Selected Subtraction");
                int diff = sub(num1, num2);
                Console.Write(diff);
                break;
            case 3:
                Console.WriteLine("Selected Division");
                int div = division(num1, num2);
                Console.Write(div);
                break;
            case 4:
                Console.WriteLine("Selected Multiplication");
                int product = multi(num1, num2);
                Console.Write(product);
                break;
            default:
                Console.WriteLine("Enter a valid selextion");
                break;




        }
    }
}
