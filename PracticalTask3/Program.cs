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
