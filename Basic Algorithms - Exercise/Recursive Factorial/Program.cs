using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            int result = Factorial(factorial);
            Console.WriteLine(result);
        }

        private static int Factorial(int num)
        {
            if(num == 0)
            {
                num = 1;
                return num;
            }

            return num *= Factorial(num - 1);
        }
    }
}
