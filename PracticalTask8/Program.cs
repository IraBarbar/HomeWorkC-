/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] GreatRandom2dArray()
{
    int rows = new Random().Next(2, 6);
    int colums = new Random().Next(2, 6);
    int minValue = new Random().Next(0, 10);
    int maxValue = new Random().Next(10, 50);
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0 && array[i, j] < 10)
                Console.Write($" {array[i, j]}   ");
            if (array[i, j] > -10 && array[i, j] < 0)
                Console.Write($"{array[i, j]}   ");
            if (array[i, j] >= 10)
                Console.Write($" {array[i, j]}  ");
            if (array[i, j] <= -10)
                Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = GreatRandom2dArray();
Show2dArray(myArray);

void SortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxposj = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxposj])
                    maxposj = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxposj];
            array[i, maxposj] = temp;
        }
    }
}

SortToMin(myArray);
Show2dArray(myArray);