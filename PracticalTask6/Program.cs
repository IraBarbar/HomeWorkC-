/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
/*
void ShowArray ( int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine(); 
}

int[] FillArray(int size)
{
   int [] arr = new int [size];
   int a = 0;
   for(int i = 0; i < size; i++)
   {
        Console.WriteLine("Input a number: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        int temp = arr[i];
        arr[i] = a;
        a = temp;
   }
return arr;
}

int SumPositiveElement(int [] array)
{
    int sum = 0;
    for(int i =0; i < array.Length; i ++)
    {
        if (array[i] > 0) sum ++ ;
    }
return sum;
}

Console.WriteLine("How many numbers are you planning to ente?");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = FillArray(n);
ShowArray (array);

Console.WriteLine("Positive elements are " + SumPositiveElement(array));
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/* 
double [] PointInter(double b1, double k1, double b2, double k2)
{
    double [] point = new double [2];
    
    double x = -((b1 - b2) / (k1 - k2));
    double y = (k2 * x + b2);   
    point[0] = x;
    point[1] = y;
    
    return point;
}
bool TestLine(double k1, double k2)
{
  if (k1 - k2 != 0) return true;
  else return false;
}

void ShowArray ( double [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array [i],3)+ "  ");
    Console.WriteLine(); 
}
Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());        

Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (TestLine( k1, k2) == true)
{
    double [] coordinates = PointInter(b1, k1, b2, k2);
    Console.Write("Line intersection coordinates: ");
    ShowArray(coordinates);
}
else Console.WriteLine("Straight lines don't intersect!");
*/
// Оптимизация!

void Coordinates(double b1, double k1, double b2, double k2)
{
    if (k2 - k1 == 0)
    {
        Console.WriteLine("Straight lines don't intersect!");
    }
    else
    {
        double x = -((b2 - b1) / (k2 - k1));
        double y = (k2 * x + b2);
        Math.Round(x, 3); Math.Round(y, 3);
        Console.WriteLine($"Line intersection coordinates: ({x} ; {y})");
    }
}

Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Coordinates(b1, k1, b2, k2);