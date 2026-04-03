using System;

class Program
{
    static void Main()
    {

        // Exercise 1
        Console.WriteLine("Exercise 1:");

        Console.WriteLine("Enter first number:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("Numbers are equal");
        }
        else
        {
            if (a > b)
            {
                Console.WriteLine("First number is greater");
            }
            else
            {
                Console.WriteLine("First number is less");
            }
        }


        // Exercise 2
        Console.WriteLine("Exercise 2:");

        Console.WriteLine("Enter a number:");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 5 && num < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }


        // Exercise 3
        Console.WriteLine("Exercise 3:");

        Console.WriteLine("Enter a number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 5 || num2 == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }


        // Exercise 4
        Console.WriteLine("Exercise 4:");

        Console.WriteLine("Enter deposit amount:");
        double deposit = Convert.ToDouble(Console.ReadLine());

        double result = deposit;

        if (deposit < 100)
        {
            result = deposit + deposit * 0.05;
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            result = deposit + deposit * 0.07;
        }
        else
        {
            result = deposit + deposit * 0.10;
        }

        Console.WriteLine("Deposit with interest: " + result);


        // Exercise 5
        Console.WriteLine("Exercise 5:");

        Console.WriteLine("Enter deposit amount:");
        double deposit2 = Convert.ToDouble(Console.ReadLine());

        double result2 = deposit2;

        if (deposit2 < 100)
        {
            result2 = deposit2 + deposit2 * 0.05;
        }
        else if (deposit2 >= 100 && deposit2 <= 200)
        {
            result2 = deposit2 + deposit2 * 0.07;
        }
        else
        {
            result2 = deposit2 + deposit2 * 0.10;
        }

        result2 = result2 + 15;

        Console.WriteLine("Deposit with interest and bonus: " + result2);


        // Exercise 6
        Console.WriteLine("Exercise 6:");

        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication");

        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Addition");
                break;

            case 2:
                Console.WriteLine("Subtraction");
                break;

            case 3:
                Console.WriteLine("Multiplication");
                break;

            default:
                Console.WriteLine("Operation undefined");
                break;
        }


        // Exercise 7
        Console.WriteLine("Exercise 7:");

        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication");

        int op2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter first number:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double y = Convert.ToDouble(Console.ReadLine());

        switch (op2)
        {
            case 1:
                Console.WriteLine("Result: " + (x + y));
                break;

            case 2:
                Console.WriteLine("Result: " + (x - y));
                break;

            case 3:
                Console.WriteLine("Result: " + (x * y));
                break;

            default:
                Console.WriteLine("Operation undefined");
                break;
        }

    }
}