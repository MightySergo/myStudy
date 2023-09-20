// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using Microsoft.VisualBasic.CompilerServices;
Console.WriteLine("Enter you integer ");
int usersNumber = Convert.ToInt32(Console.ReadLine());
if (usersNumber%2 == 0){
    Console.WriteLine("Your number is even");
} else {
    Console.WriteLine("Your number is odd");
}

