// See https://aka.ms/new-console-template for more information
int grade, age, bet;

Console.WriteLine("What was your grade?");
int.TryParse(Console.ReadLine(), out grade);
if (grade >= 50)
    Console.WriteLine("You Passed!");
else
    Console.WriteLine("Better luck next time");
Console.WriteLine();

Console.WriteLine("What is your age?");
int.TryParse(Console.ReadLine(), out age);
if (age >= 16)
    Console.WriteLine("The roads are not safe.");
else
    Console.WriteLine("I can drive without fear.");
Console.WriteLine();

Console.WriteLine("How much would you like to bet? ");
if (int.TryParse(Console.ReadLine(), out bet))
{
Console.WriteLine("You bet " + bet.ToString("C"));
}
else
{
Console.WriteLine("That is not a valid number.");
Console.WriteLine("Your bet will be set to the minimum of $1.00.");
bet = 1;
}
Console.WriteLine();

Console.WriteLine("What was your grade?");
int.TryParse(Console.ReadLine(), out grade);

if (grade < 50)
    Console.WriteLine("That is an F!");
else if (grade <= 65)
    Console.WriteLine("That is a D!");
else if (grade <= 75)
    Console.WriteLine("That is a C!");
else if (grade <= 85)
    Console.WriteLine("That is a B!");
else
    Console.WriteLine("That is an A!");
Console.WriteLine();

string choice;
Console.WriteLine("Who is the greatest Starship Captain?");
Console.WriteLine("a - Captain James Kirk                b - Captain Crunch");
Console.WriteLine("c - Captain Jean Luc Picard           d - Captain Han Solo");
Console.WriteLine();
Console.Write(">>");
choice = Console.ReadLine().ToLower();
Console.WriteLine();
if (choice == "a")
{
    Console.WriteLine("Good guess, but Kirk is no Picard.");
}
else if (choice == "b")
{
    Console.WriteLine("I said starship captain!  Althoguh he does make an good cereal.");
}
else if (choice == "c")
{
    Console.WriteLine("This is the only correct answer.");
}
else if (choice == "d")
{
    Console.WriteLine("Being in charge of a single wookie doesn't make you a great captain.");
}
else
{
    Console.WriteLine("You have made an invalid selection.  To the brig...");
}
Console.WriteLine();

int temp;
Console.WriteLine("Please enter the temperature of the H2O: ");
if (int.TryParse(Console.ReadLine(), out temp))
{
    if (temp <= 0)
        Console.WriteLine("You have a solid.");
    else if (temp < 100)
        Console.WriteLine("You have liquid!");
    else
        Console.WriteLine("You have gas!");
}
else
{
    Console.WriteLine("Invalid input");
}
Console.WriteLine();

string name;
Console.Write("Hey, what's your name? ");
name = Console.ReadLine();
Console.WriteLine();
Console.Write("Ok, " + name + ", how old are you?  ");
if (int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine();
    if (age < 0)
    {
        Console.WriteLine("I didn't know fetuses could use a computer!");
    }
    else if (age < 16)
    {
        Console.WriteLine("You can't drive.");
    }
    else if (age < 18)
    {
        Console.WriteLine("You can't vote.");
    }
    else if (age < 25)
    {
        Console.WriteLine("You can't rent a car.");
    }
    else
    {
        Console.WriteLine("You can do anything that is legal.");
    }
}
else
{
    Console.WriteLine("Invalid Numeric Input");
}