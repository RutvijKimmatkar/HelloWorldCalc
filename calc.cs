using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    
    static float add(float num1, float num2)
    {
        Console.Write(num1 + "+" + num2 + "=");
        return num1 + num2;
    }
    static float sub(float num1, float num2)
    {
        Console.Write(num1 + "-" + num2 + "=");
        return num1 - num2;
    }
    static float division(float num1, float num2)
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
    static float multi(float num1, float num2)
    {
        Console.Write(num1 + "x" + num2 + "=");
        return num1 * num2;
    }

    //backup
    
    static void Main()
    {
        List<string> history= new List<string>();
        int historyindex=0;
        bool userchoice = true;
        string operationsign="na";
        while(userchoice)
        {
        Console.Clear();
        Console.WriteLine("Welcome to Calculator. Select an operation.");
        Console.WriteLine("1.Addition\n2.Subtraction\n3.Division\n4.Multiplication\n5.History\n6.Exit\n7.Factorial");
        bool validation = (!float.TryParse(Console.ReadLine(), out float operation)) || operation < 1 || operation > 7; // if true, input is stored in float operation(aka output or out)
        // || is OR operator, ! is negation.
        // if any of the edge cases is true,
        // validation will take place, else not. all need not be true, only one is sufficient.
        // float.tryparse converts string to float,
        // if successful returns true, if not returns false.
        // we used negation here for tryparse. we expect a number, so when we receive a number we negate it to give way to other checks on the right.
        if (validation)
        {
            Console.WriteLine("Please enter a valid number.");
            Console.ReadKey();
            continue; //this line is important, else program continues. we are in a void so dont put return 0;
        }
        if(operation==5)
        {
            if(history.Count==0)
            {
                Console.WriteLine("history is empty, press any key to continue");
                Console.ReadLine();
            }
            else
            foreach(string n in history)
            {
                Console.WriteLine(n);

                
            }
            Console.WriteLine("press any key to continue");
            Console.ReadLine();            
            continue;
        }
        if(operation==6)
        {
            Console.WriteLine("Thank you!");
            break;
        }
        if(operation==7)
        {
            Console.WriteLine("Selected Factorial");
            Console.WriteLine("enter number");
            int fact=Convert.ToInt32(Console.ReadLine());
            int result1=1;
            for(int i =1; i<=fact; i++)
            {
               result1=result1*i;
            }
            Console.WriteLine(result1);
            string expression =(fact+"!"+"="+result1);
            history.Add(expression);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            continue;
        }                   
        Console.WriteLine("enter first number");
        if ((!float.TryParse(Console.ReadLine(), out float num1)))
        {
            Console.WriteLine("Enter a valid number.");
            return;
        }
        Console.WriteLine("enter second number");
        if ((!float.TryParse(Console.ReadLine(), out float num2)))
        {
            Console.WriteLine("Enter a valid number.");
            return;
        }

        float result = 0;
        switch (operation)
        {
            case 1:
                Console.WriteLine("Selected Addition");
                float sum = add(num1, num2);
                result = sum;
                operationsign="+";
                break;
            case 2:
                Console.WriteLine("Selected Subtraction");
                float diff = sub(num1, num2);
                result = diff;
                operationsign="-";
                break;
            case 3:
                Console.WriteLine("Selected Division");
                float div = division(num1, num2);
                result = div;
                operationsign="/";
                break;
            case 4:
                Console.WriteLine("Selected Multiplication");
                float product = multi(num1, num2);
                result = product;
                operationsign="x";
                break;
            case 7:
                
            
            default:
                Console.WriteLine("Enter a valid selection");
                break;
        }
        Console.Write(result); //reduced redunduncy
        string calculation =(num1+operationsign+num2+"="+result);
        history.Add(calculation);
        Console.WriteLine("\nWould you like to continue? Enter 'exit' to quit.");
        if((Console.ReadLine()=="exit"))
        {
            userchoice=false;
            Console.WriteLine("Thank you!");

        }

        }

    }
    }

