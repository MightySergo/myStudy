// Напишите программу, 
// которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void InterceptionPoint (){
    Console.WriteLine("Enter k1 value for f(x) function: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b1 value for f(x) function: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter k2 value for g(x) function: ");
    double k2 =  Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter b2 value for g(x) function: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    if (k1 == k2)
    {
        Console.WriteLine("The lines are parallel.");
        return;
    }
// Set the equations equal 
// k1 * x + b1 = k2 * x + b2
// k1x-k2x = b2 - b1
// x(k1-k2) = b2-b1
// x = (b2-b1)/(k1-k2)

    double x = (b2-b1)/(k1-k2);
    Console.WriteLine($"x is equal {x:f2}");
    double y = k1 * x + b1;
    Console.WriteLine($"y is equal {y:f2}");
    Console.Write($"Interception point is {x:f2},{y:f2}");    
}

InterceptionPoint();
