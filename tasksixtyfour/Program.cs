// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string NaturalNumbersfromNToOne(int Number){
    if (Number == 1) return string.Empty + "1";
    else return Number+", " + NaturalNumbersfromNToOne(Number-1);
}

Console.Write($"{NaturalNumbersfromNToOne (10)}");


