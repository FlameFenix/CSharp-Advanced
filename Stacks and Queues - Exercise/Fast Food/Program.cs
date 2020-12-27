using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            Queue<int> queueNums = new Queue<int>(orders);
            string maxOrder = string.Empty;
            if(queueNums.Count > 0)
            {
                maxOrder = queueNums.Max().ToString();
            }
            
            while (queueNums.Count != 0 && foodQuantity - queueNums.Peek() >= 0)
            {
                if(foodQuantity - queueNums.Peek() >= 0)
                {

                    foodQuantity -= queueNums.Dequeue();
                }
                else
                {
                    break;
                }
                
            }
            if(queueNums.Count == 0)
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine($"Orders left: {string.Join(" ", queueNums)}");
            }

        }
    }
}
