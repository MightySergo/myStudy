// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void PowerAB(double numberA, int numberB){
    
    double totalNumber = numberA;
    for (int i = 1; i < numberB; i++) // Можно конечно воспользоваться библиотекой Math, но думается задумка этого задания не в этом
    {
        totalNumber*=numberA;
    }
    Console.WriteLine($"Your total number is {totalNumber}");
}

Console.WriteLine("Enter your number: ");
double userN = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter numbers power: ");
int userP = Convert.ToInt32(Console.ReadLine());

PowerAB(userN, userP);
