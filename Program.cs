using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            long sum1 = 0;
            long sum2 = 0;

            for(int i=1; i <=n; i++)
            {
                sum1 = sum1 + (i * i);
            }

            sum2 = Convert.ToInt64(Math.Pow((n * (n + 1)) / 2, 2));


            Console.WriteLine("Square of the sum of the first one hundred natural numbers: " + sum2);
            Console.WriteLine("Sum of the squares of the first one hundred natural numbers: " + sum1);
            Console.WriteLine("The difference: " + (sum2-sum1));
            Console.ReadLine();
        }
    }
}
