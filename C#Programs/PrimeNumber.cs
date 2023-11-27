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
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            // Omit 0 and 1 as they are neither prime nor composite
          
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (n == 1 || n == 0)
            {
                Console.Write("Neither prime nor composite");
            }
            else if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
