using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetwayCodeSolution17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] shelf = { 1234567, 1234567, 2345678, 2345678, 3456789, 3456789, 1234567, 2345678, 3456789, 4567890, 4567890, 5678901, 5678901, 6789012, 6789012, 1234567, 2345678, 3456789, 4567890, 5678901, 4567890, 5678901 };
            Console.WriteLine(CanOrganizeBooks(shelf) ? "YES" : "NO");
            Console.ReadLine();
        }
        static bool CanOrganizeBooks(int[] shelf)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            foreach (var num in shelf)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }
            var counts = countMap.Values.ToList();
            int gcdValue = counts[0];
            for (int i = 1; i < counts.Count; i++)
            {
                gcdValue = GCD(gcdValue, counts[i]);
                if (gcdValue == 1)
                {
                    return false; 
                }
            }
            return gcdValue > 1;
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
