using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
               
            
            Console.Write("Enter a number: ");
            int var = int.Parse(Console.ReadLine());

                sum = var + sum;
            }
            Console.WriteLine($"The sum of these numbers is {sum}");
            Console.ReadLine();
        }
    }
}
