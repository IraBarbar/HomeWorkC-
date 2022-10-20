/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*
bool CheckCorrectNum(int n)
{
    if(( n > 9999 && n < 100000) || (n > -100000 && n < -9999) ) return true;
    else return false;
}

void CheckPolindromNum(int n)
{
    if (n % 10 == n / 10000 && n / 10 % 10 == n /1000 % 10)
        Console.WriteLine("This number is a polindrome.");
    else 
        Console.WriteLine(" This  number isn't a polindrome.");
}

Console.WriteLine("Please, input a five-digit number.");
int n = Convert.ToInt32(Console.ReadLine());


bool test = CheckCorrectNum(n);

while( test == false)
{
    Console.WriteLine("The number is wrong! Please, input a five-digit number. ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    bool newtest = CheckCorrectNum(n1);
    n = n1;
    test = newtest;
}

CheckPolindromNum(n);
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void FindLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double a = x2 - x1;
    double b = y2 - y1;
    double c = z2 - z1;
    double length = Math.Round(Math.Sqrt(a * a + b * b + c * c), 2);

    Console.WriteLine(length);
}

Console.WriteLine("Input a point A coordinate x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a point A coordinate y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a point A coordinate z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a point B coordinate x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a point B coordinate y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a point B coordinate z2");
int z2 = Convert.ToInt32(Console.ReadLine());

FindLength(1, y1, z1, x2, y2, z2);