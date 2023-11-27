using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    public class Fibonacci
    {
        
        static void Main(string[] args)
        {
            Pattern.Pattern1();
            PrimeNumber.Prime();
            Console.WriteLine("");
            int n1 = 0, n2 = 1, n3, number;

            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.Read();
        }
    }
}
