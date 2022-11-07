    //№25с Напишите цикл, который принимает на вход числа (А и В) и возводит число А в натуральную степень В.
    /*
        int FindDegree(int a , int b)
        {
            int product = a;
            for(int i = 2 ; i <= b ; i++)
            product = a * product;
            return product;
        }

        bool TestNum (int b)
        {
            if (b>0) return true;
            else return false;
        }      

        Console.Write("Input  number A ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  natural number B ");
        int b = Convert.ToInt32(Console.ReadLine());

            if (TestNum (b) == false) 
            {
                Console.WriteLine($"Wrong number! Input  natural number B");
                int b2 = Convert.ToInt32(Console.ReadLine());
                b = b2;
            }    
        
        Console.WriteLine($"{FindDegree(a,b)}");
    */
    //№27 Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

    int FindSumNum (int n)
    {
        if (n<0) 
        n = n * -1;

        int sum = 0;
         while (n !=0)
        {
            int a = n % 10;
            n = n / 10;
            sum = sum + a;

        }
            return sum;
          
    }
    Console.Write("Input a number  ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{FindSumNum (n)}");