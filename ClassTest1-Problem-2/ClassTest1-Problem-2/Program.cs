using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, i, flag = 0;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            int a = 0;
            while (n != 0)
            {
                r = n % 10;
                a = a * 10 + r;
                n = n / 10;
            }
            //Checking Prime or not Prime 
            for (i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    Console.Write("Result is: " + a + "(Not Prime)");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Result is: " + a + "(Prime)");

        }
    }
}
