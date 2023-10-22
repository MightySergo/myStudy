// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int SumFromNToM(int numberOne, int numberTwo){
    if (numberOne  == numberTwo) return numberTwo;
    if (numberOne < numberTwo){
        return numberOne + SumFromNToM(numberOne +1, numberTwo);
    }
    else return numberOne + SumFromNToM(numberOne -1, numberTwo);
}

Console.Write($"{SumFromNToM (8,4)}");
