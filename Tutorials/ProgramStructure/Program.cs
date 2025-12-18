// A skeleton of a C# program
/*using System;
namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }

    class Program
{
        //The runtime calls the Main method when you start a C# application. The Main method is the entry point of a C# application.
        //A C# program can have only one entry point. If there is more than one class with a Main method,
        //TheStartupObject compiler option must be used when compile the program to specify which Main method serves as the entry point.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }
}*/

/*using System.Text;

//Top-level statement can be used as an entry point
//They can return variable and access command line arguments
StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");

foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}

Console.WriteLine(builder.ToString());

return 0;*/

//The Main method is the entry point of an executable program. It's where the program control starts and ends.
//Main must be declared inside a class or struct. The enclosing class can be static.
//Main must be static.
//Main can have any access modifier.
//Main can return void, int, Task, or Task<int>.
//If and only if Main returns a Task or Task<int>, the declaration of Main can include the async modifier. This rule specifically excludes an async void Main method.
//Main method can be declared with or without a string[] parameter that contains command-line arguments.
//Examples of main method declarations:
/*
static void Main() { }                          //No use of args or await
static int Main() { }                           //No use of args or await
static void Main(string[] args) { }             //Uses args but not await
static int Main(string[] args) { }              //Uses args but not await
static async Task Main() { }                    //Uses await but not args
static async Task<int> Main() { }               //Uses await but not args
static async Task Main(string[] args) { }       //Uses args and await   
static async Task<int> Main(string[] args) { }  //Uses args and await
*/

//The preceding examples don't specify an access modifier, so they're implicitly private by default.

//If the return value from Main isn't used, returning void or Task allows for slightly simpler code.
/*
static void Main()                              //No use of args or await
static void Main(string[] args)                 //Uses args but not await
static async Task Main()                        //Uses await but not args
static async Task Main(string[] args)           //Uses args and await
*/
//However, returning int or Task<int> enables the program to communicate status information to other programs or scripts that invoke the executable file.

/*class MainReturnValTest
{
    static int Main()
    {
        //...
        return 0;
    }
}*/
