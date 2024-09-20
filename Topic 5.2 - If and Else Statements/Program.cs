// See https://aka.ms/new-console-template for more information
int grade;
Console.WriteLine("What was your grade?");
int.TryParse(Console.ReadLine(), out grade);
if (grade >= 50)
    Console.WriteLine("You Passed!");
else
    Console.WriteLine("Better luck next time");