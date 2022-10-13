// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write($"{number1} - max, {number2} - min");
}
else
{
    Console.Write($"{number2} - max, {number1} - min ");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.WriteLine($" Max is {max} ");
*/

//Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/


Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) Console.Write((number) + " - Even (четное) number.");
else  Console.Write((number) + " - Odd (нечетное) number.");


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= N)
{
    if(i % 2 == 0) Console.Write((i) + ", ");
    i++;
}
*/

