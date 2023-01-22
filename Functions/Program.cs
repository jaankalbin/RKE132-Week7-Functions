// See https://aka.ms/new-console-template for more information
Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();
if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}static void PrintHello() //function ehk meetod
{
    Console.WriteLine("Hello, world!");
}
static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator.");
}