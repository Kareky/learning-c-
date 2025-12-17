//Testing String Formatting
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//Testing Currency Formatting
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Testing Percentage Formatting
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");