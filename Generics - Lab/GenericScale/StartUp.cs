using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> numbers = new EqualityScale<int>(10, 10);

            Console.WriteLine(numbers.AreEqual());
        }
    }
}
