using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = ArrayCreator.Create(10, 10);

            Console.WriteLine(string.Join(" ", arr));

            string[] array2 = ArrayCreator.Create(5, "Cheaters");

            Console.WriteLine(string.Join(", ", array2));
        }
    }
}
