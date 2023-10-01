// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter your number:");
int userDigit = Convert.ToInt32(Console.ReadLine());

if ((userDigit+1)%7 == 0 || userDigit%7 == 0)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}
