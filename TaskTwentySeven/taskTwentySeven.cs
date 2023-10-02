// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumDigits (int digit){
    
    int summed = 0;
    while (digit != 0)
    {
        int number = digit%10;
        summed += number;
        digit /= 10;
    }
    return summed;
}

Console.WriteLine ("Enter your number: ");
Console.WriteLine($"Sum of digits: {SumDigits(Convert.ToInt32(Console.ReadLine()))}");
