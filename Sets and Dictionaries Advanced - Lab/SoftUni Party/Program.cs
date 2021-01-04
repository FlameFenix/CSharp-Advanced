using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest = Console.ReadLine();

            HashSet<string> vip = new HashSet<string>();
            HashSet<string> others = new HashSet<string>();

            bool isEnd = false;

            while (guest != "PARTY")
            {
                

                if(guest[0] >= 48 && guest[0] <= 57)
                {
                    vip.Add(guest);
                }
                else
                {
                    others.Add(guest);
                }

                guest = Console.ReadLine();
                if(guest == "PARTY")
                {
                    while (guest != "END")
                    {
                        if (vip.Contains(guest))
                        {
                            vip.Remove(guest);
                        }
                        else if (others.Contains(guest))
                        {
                            others.Remove(guest);
                        }
                        guest = Console.ReadLine();
                        if(guest =="END")
                        {
                            isEnd = true;
                            break;
                        }
                    }
                }

                if(isEnd)
                {
                    break;
                }
            }

            Console.WriteLine($"{vip.Count + others.Count}");

            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in others)
            {
                Console.WriteLine(item);
            }
        }
    }
}
