using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фібоначчі
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine());

            int perv = 1;
            Console.Write("{0} ", perv);
            int vtor = 1;
            Console.Write("{0} ", vtor);
            int sum = 0;

            while (number >= sum)
            {
                sum = perv + vtor;

                Console.Write("{0} ", sum);

                perv = vtor;
                vtor = sum;
            }

            Console.ReadLine();
        }
    }
}
