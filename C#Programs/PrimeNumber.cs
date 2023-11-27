using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    public static class PrimeNumber
    {
        public static void Prime()
        {
            int number, i, m, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            number = int.Parse(Console.ReadLine());
            // Omit 0 and 1 as they are neither prime nor composite
          
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (number == 1 || number == 0)
            {
                Console.Write("Neither prime nor composite");
            }
            else if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
