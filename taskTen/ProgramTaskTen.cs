// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter your three-digit number");
int userDigit = Convert.ToInt32(Console.ReadLine());
if (userDigit<100 || userDigit>999){
Console.WriteLine("Your number is invalid");
return;
}
string convertedDigit = Convert.ToString(userDigit);
Console.WriteLine("Your digit is {0}",convertedDigit[1]);
