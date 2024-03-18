using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysofCode.Array_Program
{
    internal class addition
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter Any Number:");

            i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Number is Even3");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

