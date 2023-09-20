//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter your integer ");
int usersNumber = Convert.ToInt32(Console.ReadLine());
int remainder = 2;
if (usersNumber < 2){
    Console.WriteLine("Zero even numbers between your number and one");
} else{
    Console.Write("Even numbers between your number and one:");
    while (usersNumber >= 2){
        Console.Write($" { remainder}");
        remainder+= 2;
        usersNumber-=2;
    }
}