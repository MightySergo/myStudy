// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Enter your number");
int userDigit = Convert.ToInt32(Console.ReadLine());
if (userDigit<100){
Console.WriteLine("No third digit");
return;
}
string convertedDigit = Convert.ToString(userDigit);
Console.WriteLine("Your digit is {0}",convertedDigit[2]);
