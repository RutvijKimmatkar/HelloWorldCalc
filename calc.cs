using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Xml.XPath;
using System.Linq.Expressions;
using System.Collections;

class Program
{
    static float Add(float num1, float num2)
    {
        Console.Write(num1 + "+" + num2 + "=");
        return num1 + num2;
    }
    static float Subtract(float num1, float num2)
    {
        Console.Write(num1 + "-" + num2 + "=");
        return num1 - num2;
    }
    static float Divide(float num1, float num2)
    {
        while(num2==0)
        {
            Console.WriteLine("division is not possible by zero");
            Console.WriteLine("enter new second number");
            num2=Convert.ToInt32(Console.ReadLine());
        }
        Console.Write(num1 + "/" + num2 + "=");
        return num1 / num2;
    }
    static float Multiply(float num1, float num2)
    {
        Console.Write(num1 + "x" + num2 + "=");
        return num1 * num2;
    }
    static void Main()
    {
        List<string> history= new List<string>();
        bool userchoice = true;
        string operationsign="na";
        
        while(userchoice)
        {
        float result=1;
        float num1=1, num2=1;
        Console.Clear();
        Console.WriteLine("Welcome to Calculator. Select an operation.");
        Console.WriteLine("");
        //Console.WriteLine("1.Addition\n2.Subtraction\n3.Division\n4.Multiplication\n5.History\n6.Exit\n7.Factorial\n8.Powers");
        Console.WriteLine("1.Addition           9.History\n2.Subtraction        10.Exit\n3.Division\n4.Multiplication\n5.Factorial\n6.Powers");
        Console.WriteLine("");
        Console.Write("Select: ");
        bool validation = (!float.TryParse(Console.ReadLine(), out float operation)) || operation < 1 || operation > 10; // if true, input is stored in float operation(aka output or out)
        // || is OR operator, ! is negation.
        // if any of the edge cases is true,
        // validation will take place, else not. all need not be true, only one is sufficient.
        // float.tryparse converts string to float,
        // if successful returns true, if not returns false.
        // we used negation here for tryparse. we expect a number, so when we receive a number we negate it to give way to other checks on the right.
        if (validation)
        {
            Console.WriteLine("Please enter a valid number. Press any key to continue.");
            Console.ReadKey();
            continue;
        }
        if(operation==10)
        {
            Console.WriteLine("Thank you!");
            break;
        }
        else if(operation==9)
        {
            if(history.Count==0)
            {
                Console.WriteLine("history is empty, press any key to continue");
                Console.ReadKey();
                continue;
            }
            else
            foreach(string n in history)
            {
                Console.WriteLine(n);
                Console.WriteLine("press any key to continue");
            }
            Console.ReadKey();

            continue;
        }
            switch(operation)
            {
                case 1:
                    Console.WriteLine("Selected Addition");
                    break;
                case 2:
                    Console.WriteLine("Selected Subtraction");
                    break;
                case 3:
                    Console.WriteLine("Selected Division");
                    break;
                case 4:
                    Console.WriteLine("Selected Multiplication");
                    break;
            }

        switch(operation)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("enter first number");
                if ((!float.TryParse(Console.ReadLine(), out num1)))
                {
                    Console.WriteLine("Enter a valid number.");
                    continue;
                }
                Console.WriteLine("enter second number");
                if ((!float.TryParse(Console.ReadLine(), out num2)))
                {
                    Console.WriteLine("Enter a valid number.");
                    continue;
                }
                switch(operation)
                {
                    case 1:
                        //Console.WriteLine("Selected Addition");
                        float sum = Add(num1, num2);
                        result = sum;
                        operationsign="+";
                        break;
                    case 2:
                        //Console.WriteLine("Selected Subtraction");
                        float diff = Subtract(num1, num2);
                        result = diff;
                        operationsign="-";
                        break;
                    case 3:
                        //Console.WriteLine("Selected Division");
                        float div = Divide(num1, num2);
                        result = div;
                        operationsign="/";
                        break;
                    case 4:
                        //Console.WriteLine("Selected Multiplication");
                        float product = Multiply(num1, num2);
                        result = product;
                        operationsign="x";
                        break;
                }   
            break;
            case 5:
                Console.WriteLine("Selected Factorial");
                Console.WriteLine("enter number");
                int fact=Convert.ToInt32(Console.ReadLine());
                for(int i =1; i<=fact; i++)
                {
                result=result*i;
                }
                string expression =(fact+"!"+"="+result);
                history.Add(expression);
                Console.Write("factorial of "+ fact + " is ");
                break;
            case 6:
                Console.WriteLine("enter base number");
                //basenum
                num1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter power");
                //powernum
                num2=Convert.ToInt32(Console.ReadLine());
                for(int i=0; i<num2; i++)
                {
                    result=result*num1;
                }
                Console.Write(num1+" raised to " + num2 +" is ");
                operationsign="raised to";
                break;            
            default:
                Console.WriteLine("Enter a valid selection");
                break;
        }
        Console.WriteLine(result);
        string calculation =(num1+" "+operationsign+" "+num2+" "+"="+" "+result);
        history.Add(calculation);
        Console.WriteLine("Press any key to continue, type 'exit' to quit");
        if((Console.ReadLine()=="exit"))
        {
            userchoice=false;
            Console.WriteLine("Thank you!");
        }
        }
    }
    }

