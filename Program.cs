using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = lonelyinteger(a);

            Console.WriteLine(result);
        }

        private static int lonelyinteger(List<int> a)
        {
            //solution with xor 
            var result = 0;
            foreach (var item in a)
            {
                result = result ^ item;

            }

            return result;
            //solution with hashset 
            //var uniqueSet = new HashSet<int>();
            //foreach (var item in a)
            //{
            //    if (uniqueSet.Contains(item))
            //    {
            //        uniqueSet.Remove(item);
            //    }
            //    else
            //    {
            //        uniqueSet.Add(item);
            //    }

            //}

            //return uniqueSet.First();
        }
    }
}
