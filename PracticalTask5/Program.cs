/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(minValue, maxValue + 1);
    }
    return array;
} 
*/
void ShowArray ( int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();    
}
/*
Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] CreateRandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(100, 1000);
    }
    return array;
}

int SumEvenElement  (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count ++;
    return count;
}

Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine ( "Sum of even elements = "+(SumEvenElement  (myArray)));