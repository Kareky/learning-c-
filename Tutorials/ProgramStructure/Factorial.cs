//The following example shows how to use command-line arguments in a console application.
//The application takes one argument at run time, converts the argument to an integer,and calculates the factorial of the number.
//If no arguments are supplied, the application issues a message that explains the correct usage of the program.
public class Functions
{
    public static long Factorial(int n)
    {
        // Test for invalid input.
        if ((n < 0) || (n > 20))
        {
            return -1;
        }

        // Calculate the factorial iteratively rather than recursively.
        long tempResult = 1;
        for (int i = 1; i <= n; i++)
        {
            tempResult *= i;
        }
        return tempResult;
    }
}

class MainClass
{
    static int Main(string[] args)
    {
        //The program tests if input arguments weren't supplied by comparing
        //the length of the args argument to 0 and displays the help if no arguments are found.
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        //The program tries to convert the input arguments to numbers.
        //Throws an exception if the argument isn't a number.
        int num;
        bool test = int.TryParse(args[0], out num);
        if (!test)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        //the verbose result is printed depending on the result variable.
        long result = Functions.Factorial(num);

        if (result == -1)
            Console.WriteLine("Input must be >= 0 and <= 20.");
        else
            Console.WriteLine($"The Factorial of {num} is {result}.");

        return 0;
    }
}