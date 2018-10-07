using System;

namespace Factorial
{
    class Program
    {
        static int ReFactorial(int n)
        {
            int i = 1;

            while (n > i)
            {
                if (n % i != 0)
                    return -1;
                n /= i;
                ++i;
            }

            if (i == n)
                return i;
            return -1;
        }

        static void Main()
        {
            Console.WriteLine(ReFactorial(5040));
            Console.ReadKey();
        }
    }
}
