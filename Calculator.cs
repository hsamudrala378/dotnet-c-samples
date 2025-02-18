// See https://aka.ms/new-console-template for more information
int num1, num2;
int result;
string answer;
Console.WriteLine("Hello,Welcome to the calculator");
Console.WriteLine("Please Enter your first number.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter your Second number.");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "What type of operation would you like to do?");
Console.WriteLine( "Please enter a for addition, s for subtraction, m for multiplication or d for division");
answer = Console.ReadLine();

if (answer == "a")
{
    result = num1 + num2;
}
else if (answer == "s")
{
    result = num1 - num2;
}
else if (answer == "m")
{
    result = num1 * num2;
}
else
{
    result = num1 / num2;
}
Console.WriteLine("The result is " + result);
Console.WriteLine( "Thanks for using calculator program");


    Console.ReadKey();
