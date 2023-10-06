// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



double [] userInputArray (){
    Console.WriteLine("Enter numbers quantity: ");
    double [] userArray = new double [Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.WriteLine($"Enter your {i+1} number: ");
        userArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return userArray;
}

int countPossitiveNumbers (double [] userArray){
    int counter = 0;
    foreach (var item in userArray)
    {
        if (item > 0) counter++;
        
    }
    return counter;
}

Console.Write($"Number of possitive numbers is: {countPossitiveNumbers(userInputArray())}");