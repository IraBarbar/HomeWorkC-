/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GreatRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1)
            + new Random().NextDouble();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                Console.Write($" {Math.Round(array[i, j], 2)}   ");
            if (array[i, j] > -10 && array[i, j] < 0)
                Console.Write($"{Math.Round(array[i, j], 2)}   ");
            if (array[i, j] >= 10)
                Console.Write($" {Math.Round(array[i, j], 2)}  ");
            if (array[i, j] <= -10)
                Console.Write($"{Math.Round(array[i, j], 2)}  ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = GreatRandom2dArray(m, n, min, max);
Show2dArray(myArray);

