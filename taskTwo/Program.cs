// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter your first number ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your second number ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"Greater number is {x}");
    Console.WriteLine($"Smaller number is {y}");
}
else
{
    Console.WriteLine($"Greater number is {y}");
    Console.WriteLine($"Smaller number is {x}");
}



