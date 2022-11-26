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
/*
int[,] GreatRandom2dArray() 
{
    int rows = new Random().Next(4, 6);
    int columns = new Random().Next(4, 6);
    int minValue = new Random().Next(0, 1);
    int maxValue = new Random().Next(5, 6);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
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
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
*/
/*
int MinSumElementsRow(int[,] array)
{
    int k = 0;
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumRow[i] = sum;
        }

        int min = sumRow[0];
        if (sumRow[i] < min)
        {
            sumRow[i] = min;
            k = i;
        }
    }
    return (k + 1);
}

int a = MinSumElementsRow(myArray);
Console.WriteLine($"{a} is number rows with the smallest sum of elements.");
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
bool TestProduct2Matric(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) == arr2.GetLength(0)) return true;
    else return false;
}

int[,] Product2Matric(int[,] arr1, int[,] arr2)
{
    int[,] arrResalt = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for( int k = 0; k<arr2.GetLength(1); k++)
            {
                sum+= arr1[i,k]*arr2[k,j];
            }
            arrResalt[i, j] = sum;
        }
    return arrResalt;
}

int[,] myArray2 = GreatRandom2dArray();
Show2dArray(myArray2);

if (TestProduct2Matric(myArray, myArray2) == false)
{
    Console.WriteLine("The product of two matrices is not possible!");
    Console.WriteLine();
}
if (TestProduct2Matric(myArray, myArray2) == true)
{
    int[,] resalt = Product2Matric(myArray, myArray2);
    Console.WriteLine("The resulting matrix:");
    Show2dArray(resalt);
}
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*

int[,,] EsxlusivRandom3dArray(int rows, int columns, int cells)
{
    int size = rows * columns * cells;
    int[] array = new int[size];

    int[,,] sortArr = new int[rows, columns, cells];
    for (int k = 0; k < size;)
    {
        bool control = false;
        int n = new Random().Next(-99, 100);
        if (n > -10 && n < 10) control = true;
        for (int k1 = 0; k1 < k; k1++)
        {
            if (array[k1] == n)
            {
                control = true;
                break;
            }
        }
        if (!control)
        {
            array[k] = n;
            k++;
        }
    }
    int t = 0;
    while (t < size)
    {
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
                for (int p = 0; p < cells; p++)
                {
                    sortArr[i, j, p] = array[t];
                    t++;
                }
    }
    return sortArr;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
bool TestMean(int rows, int columns, int cells)
{
    int produck = rows * columns * cells;
    if (produck < 181 && produck > 0) return true;
    else return false;
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of cells");
int t = Convert.ToInt32(Console.ReadLine());



if (TestMean(m, n, t) == true)
{
    int[,,] myArray3 = EsxlusivRandom3dArray(m, n, t);
    Console.WriteLine();
    Show3dArray(myArray3);

}
if (TestMean(m, n, t) == false)
    Console.WriteLine("Значения элемента ограничено двухзначным числом");
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] Spiral(int n)
{
   int[,] arr = new int[n, n];
   int j = 0;
   int i = 0;
   int sti = 0;
   int stj = 0;
   int fii = n - 1;
   int fij = n - 1;
   int sum = 0;
   while (sum < n * n)
   {
       for (j = stj; j <= fij; j++)
       {
           arr[sti, j] = sum + 1;
           sum++;
       }
       sti = sti + 1;
       for (i = sti; i <= fii; i++)
       {
           arr[i, fij] = sum + 1;
           sum++;
       }
       fij = fij - 1;
       for (j = fij; j >= stj; j--)
       {
           arr[fii, j] = sum + 1;
           sum++;
       }
       fii = fii - 1;
       for (i = fii; i >= sti; i--)
       {
           arr[i, stj] = sum + 1;
           sum++;
       }
       stj = stj + 1;
   }
return arr;
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

Console.WriteLine("Input a number of rows and columns!");
int t = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Spiral(t);
Show2dArray(myArray);

