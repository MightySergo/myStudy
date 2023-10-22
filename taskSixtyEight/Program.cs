// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
long Akkerman(long m, long n){
    if (m==0) return n+1;
    if (m>0 && n==0) return Akkerman(m-1,1);
    if (m>0 && n > 0) return Akkerman(m-1, Akkerman(m,n-1));
    return 0; 
}

Console.Write($"{Akkerman(3,5)}");

// A(m, n) =

// n + 1 if m = 0
// A(m - 1, 1) if m > 0 and n = 0
// A(m - 1, A(m, n - 1)) if m > 0 and n > 0

