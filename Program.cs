// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Lets all Se this program and Its Flows");
Console.Write("Enter your Name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}");
int y = 10;
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























