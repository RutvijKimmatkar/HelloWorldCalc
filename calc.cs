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
        if (num2 == 0)
        {
            Console.WriteLine("Division is not possible by zero.");
            return 0; //this line is important else we are letting the calculation continue
        }
        Console.Write(num1 + "/" + num2 + "=");
        return num1 / num2;
    }
    static int multi(int num1, int num2)
    {
        Console.Write(num1 + "x" + num2 + "=");
        return num1 * num2;
    }

    //backup

    static void Main()
    {

        Console.WriteLine("Welcome to Calculator. Select an operation.");
        Console.WriteLine("1. Addition 2.Subtraction 3.Division 4.Multiplication");
        bool validation = (!int.TryParse(Console.ReadLine(), out int operation)) || operation < 1 || operation > 4; // if true, input is stored in int operation(aka output or out)
        // || is OR operator, ! is negation.
        // if any of the edge cases is true,
        // validation will take place, else not. all need not be true, only one is sufficient.
        // int.tryparse converts string to int,
        // if successful returns true, if not returns false.
        // we used negation here for tryparse. we expect a number, so when we receive a number we negate it to give way to other checks on the right.
        if (validation)
        {
            Console.WriteLine("Please enter a valid number.");
            return; //this line is important, else program continues. we are in a void so dont put return 0;
        }
        Console.WriteLine("enter first number");
        if ((!int.TryParse(Console.ReadLine(), out int num1)))
        {
            Console.WriteLine("Enter a valid number.");
            return;
        }
        Console.WriteLine("enter second number");
        if ((!int.TryParse(Console.ReadLine(), out int num2)))
        {
            Console.WriteLine("Enter a valid number.");
            return;
        }
        int result = 0;
        switch (operation)
        {
            case 1:
                Console.WriteLine("Selected Addition");
                int sum = add(num1, num2);
                result = sum;
                break;
            case 2:
                Console.WriteLine("Selected Subtraction");
                int diff = sub(num1, num2);
                result = diff;
                break;
            case 3:
                Console.WriteLine("Selected Division");
                int div = division(num1, num2);
                result = div;
                break;
            case 4:
                Console.WriteLine("Selected Multiplication");
                int product = multi(num1, num2);
                result = product;
                break;
            default:
                Console.WriteLine("Enter a valid selection");
                break;
        }
        Console.Write(result); //reduced redunduncy
    }
}
