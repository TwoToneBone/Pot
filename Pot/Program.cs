using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < loop; i++)
            {
                string input = Console.ReadLine();
                string end = input.Last().ToString();
                string number = input.Remove(input.Length - 1, 1);
                
                double partSum = Math.Pow(int.Parse(number), int.Parse(end));
                total += Convert.ToInt32(partSum);
            }
            Console.WriteLine(total);
        }
    }
}
