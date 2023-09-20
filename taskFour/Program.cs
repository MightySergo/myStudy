//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double[] myArray = new double[3];
int i = 0;
double max = 0; 

Console.WriteLine("Enter first number ");
myArray[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number ");
myArray[1] = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter third number ");
myArray[2] = Convert.ToDouble(Console.ReadLine()); 

while (i < myArray.Length)
{
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
    i++;
}
Console.WriteLine($"Your max number is {max}");

