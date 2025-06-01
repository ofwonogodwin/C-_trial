// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Lets all Se this program and Its Flows");
Console.Write("Enter your Name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}");
int y = 110;
int x = 30;
Console.WriteLine(x+y);
Console.WriteLine();
// Continuation from yesterday
int num = 23;
num++;
Console.WriteLine(num);

var names = "Godwin Ofwono";
Console.WriteLine($"Heyy {names}");

const int vat = 20;
Console.Write("What is your Salary :");
int balance = 100000;
int net = (balance * (vat/100));
Console.WriteLine($"Ur net Salary is {net} and gross is {balance}");

// If statements
Console.Write("Enter Score :");
int score = int.Parse(Console.ReadLine());
if (score >= 90 && score <= 100)
{
    Console.WriteLine("Grade A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade F");
}
 // Simple Adult detecting System.
Console.Write("Please Enter your Name: "); 
string named = Console.ReadLine();
Console.WriteLine($"Heyy {named},");
Console.WriteLine("Please Enter your Age");
int ages = int.Parse(Console.ReadLine());
Console.WriteLine($"{named},your age is {ages}");
if (ages >= 18)
{
    Console.WriteLine("You are eligible to vote");
}
else
{
    Console.WriteLine($"Sorry {named},You are not eligible to vote");
}

//Dealing with Loops
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{named}");
}






















