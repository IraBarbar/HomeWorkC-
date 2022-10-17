/* Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

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

