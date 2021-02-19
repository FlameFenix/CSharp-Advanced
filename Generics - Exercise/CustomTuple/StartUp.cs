using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomTuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] personNamesAndAdress = Console.ReadLine().Split().ToArray();

            string fullName = $"{personNamesAndAdress[0]} {personNamesAndAdress[1]}";

            string adress = $"{personNamesAndAdress[2]}";

            Tuple<string, string> personInfo = new Tuple<string, string>(fullName, adress);

            string[] secondInfo = Console.ReadLine().Split().ToArray();

            string name = secondInfo[0];
            int liters = int.Parse(secondInfo[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(name, liters);

            string[] thirdInfo = Console.ReadLine().Split().ToArray();

            int integer = int.Parse(thirdInfo[0]);
            double doubleNum = double.Parse(thirdInfo[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integer, doubleNum);

            Console.WriteLine(personInfo.ToString());
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
