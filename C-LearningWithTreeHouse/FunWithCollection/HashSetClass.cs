using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollection
{
    static class HashSetClass
    {
        public static void RunProgram()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();
            List<int> evenListNumber = new List<int>();
            List<int> oddListNumber = new List<int>();

            // Add 5 even numbers and 5 odd numbers
            for (int i = 0; i <= 9; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                    evenListNumber.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                    oddListNumber.Add(i);

                }
            }

            var numbers = new HashSet<int>(evenNumbers);
            numbers.UnionWith(oddNumbers);

            if (numbers.Contains(2))
            {
                Console.WriteLine("hurra");
            }
            var listNumbers2 = new List<int>();
            var list = numbers.ToList();

            list.Sort();
           
            var orderedNumbers = numbers.Count;

            



        }
    }
}
