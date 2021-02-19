using System;
using System.Linq;

namespace ThreeupleTask
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfoOne = Console.ReadLine()
                                            .Split()
                                            .ToArray();

            string fullName = $"{personInfoOne[0]} {personInfoOne[1]}";
            string adress = $"{personInfoOne[2]}";
            string town = $"{personInfoOne[3]}";

            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(fullName, adress, town);

            string[] personInfoTwo = Console.ReadLine()
                                            .Split()
                                            .ToArray();

            string name = $"{personInfoTwo[0]}";
            int litters = int.Parse(personInfoTwo[1]);
            bool isDrunk = personInfoTwo[2] == "drunk" ? true : false;

            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(name, litters, isDrunk);

            string[] personInfoThree = Console.ReadLine()
                                              .Split()
                                              .ToArray();

            string balanceOwner = $"{personInfoThree[0]}";
            double balance = double.Parse(personInfoThree[1]);
            string bankName = $"{personInfoThree[2]}";

            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>(balanceOwner, balance, bankName);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
