/* Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
bool TestThird(int N)
{
    if( N > 99 && N < 1000) return true;
    else return false;
}

int FindSecond(int N)
{
    int de = N / 10;
    int sec = de % 10;
    return sec;
}

Console.WriteLine("Please, enter the three-digit number.");
int n = Convert.ToInt32(Console.ReadLine());

bool test = TestThird(n);

int result = FindSecond(n);

if (test == true) Console.WriteLine(result);
if (test == false) Console.Write(" The number is not the three-digit number.");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/ 
bool TestNumber(int N)
{
    if( N > 99) return true;
    else return false;
}
int FindThirdNumber(int N)
{
    int ed = N % 10;
    return ed;
}

Console.WriteLine("Please, enter the  number.");
int n = Convert.ToInt32(Console.ReadLine());

bool num = TestNumber(n);

if (num == false) Console.WriteLine("The third number is not .");

int newn = n;

while (n > 1000)
{
    newn = n / 10;
    n = newn;
}
n = FindThirdNumber(n);
Console.WriteLine(n);