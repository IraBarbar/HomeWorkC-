/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void RecShowNum (int n)
{
    Console.Write(n + " ");
    if (n>1)  RecShowNum(n-1);
    if ( n< 1) RecShowNum (n+1);
}
Console.WriteLine("Input a number.");
int n = Convert.ToInt32(Console.ReadLine());
RecShowNum(n);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int RecSunFromTo(int m, int n)
{
    if (m > n) return RecSunFromTo(m - 1, n) + m;
    if (m < n) return RecSunFromTo(m + 1, n) + m;
    else return n;
}
Console.WriteLine("Input a number M.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number N.");
int n = Convert.ToInt32(Console.ReadLine());

int sum = RecSunFromTo(m, n);
if (n >= m) Console.Write($"Sum of numbers from {m} to {n} is {sum}");
else Console.Write($"Sum of numbers from {n} to {m} is {sum}");
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman((m - 1), Akkerman(m, n - 1));
}

Console.WriteLine("Input a number M greater than zero.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number N greater than zero.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool TestNum(int m, int n)
{
    if (n >= 0 && m >= 0) return true;
    else return false;
}


while (TestNum(m, n) == false)
{
    Console.WriteLine("Entered the wrong number!");
    Console.WriteLine();
    Console.WriteLine("Input a number M greater than zero.");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number N greater than zero.");
    n = Convert.ToInt32(Console.ReadLine());
}
if (TestNum(m, n) == true)
{
    int sum = Akkerman(m, n);
    if (n >= m) Console.Write($"{sum}");
    else Console.Write($"{sum}");
}