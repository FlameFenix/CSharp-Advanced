using System;

namespace BoxOfT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BoxOfT<int> generic = new BoxOfT<int>();

            generic.Add(1);
            generic.Add(2);
            generic.Add(3);

            Console.WriteLine(generic.Remove());

            Console.WriteLine(generic.Count);

            Console.WriteLine(generic.Remove());

            Console.WriteLine(generic.Count);

        }
    }
}
