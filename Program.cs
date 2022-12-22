using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 , n2;

            Console.Write("Enter First number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = n1; i < n2; i++)
            {
                int j;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                }
                if (j == i) Console.Write("{0} , ", i);
            }

            Console.ReadKey();
        }
    }
}
